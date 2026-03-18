using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace AI21;

public partial class Ai21Client : IChatClient
{
    private ChatClientMetadata? _chatMetadata;

    object? IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(ChatClientMetadata) ? (_chatMetadata ??= new(nameof(Ai21Client), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<ChatResponse> IChatClient.GetResponseAsync(
        IEnumerable<ChatMessage> messages,
        ChatOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var request = CreateChatRequest(messages, options);
        request.Stream = false;

        var response = await JambaComplete.V1ChatCompleteAsync(request, cancellationToken).ConfigureAwait(false);

        var completion = response.Value1 ?? throw new InvalidOperationException(
            "Expected a ChatCompletion response but received a streaming response.");

        return CreateChatResponse(completion, options?.ModelId);
    }

    async IAsyncEnumerable<ChatResponseUpdate> IChatClient.GetStreamingResponseAsync(
        IEnumerable<ChatMessage> messages,
        ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var request = CreateChatRequest(messages, options);
        request.Stream = true;

        var response = await JambaComplete.V1ChatCompleteAsync(request, cancellationToken).ConfigureAwait(false);

        var streamMessages = response.Value2;
        if (streamMessages is null or { Count: 0 })
        {
            yield break;
        }

        foreach (var streamMsg in streamMessages)
        {
            foreach (var choice in streamMsg.Choices)
            {
                var update = new ChatResponseUpdate
                {
                    ResponseId = streamMsg.Id,
                    Role = ChatRole.Assistant,
                    FinishReason = ToFinishReason(choice.FinishReason),
                    RawRepresentation = streamMsg,
                };

                ProcessStreamingDelta(update, choice.Delta);

                yield return update;
            }

            if (streamMsg.Usage is { } usage)
            {
                yield return new ChatResponseUpdate
                {
                    ResponseId = streamMsg.Id,
                    Role = ChatRole.Assistant,
                    Contents = [new UsageContent(CreateUsageDetails(usage))
                    {
                        RawRepresentation = usage,
                    }],
                };
            }
        }
    }

    private static void ProcessStreamingDelta(
        ChatResponseUpdate update,
        AnyOf<ChatStreamingFirstDelta, ChatStreamingContentDelta, ChatStreamingToolCallsFirstDelta, ChatStreamingToolCallsDelta> delta)
    {
        if (delta.IsValue2 && delta.Value2 is { } contentDelta)
        {
            if (!string.IsNullOrEmpty(contentDelta.Content))
            {
                update.Contents.Add(new TextContent(contentDelta.Content)
                {
                    RawRepresentation = contentDelta,
                });
            }
        }
        else if (delta.IsValue3 && delta.Value3 is { } toolCallsFirst)
        {
            foreach (var toolCall in toolCallsFirst.ToolCalls)
            {
                update.Contents.Add(new FunctionCallContent(
                    callId: toolCall.Id,
                    name: toolCall.Function.Name,
                    arguments: null)
                {
                    RawRepresentation = toolCall,
                });
            }
        }
        else if (delta.IsValue4 && delta.Value4 is { } toolCallsDelta)
        {
            foreach (var toolCall in toolCallsDelta.ToolCalls)
            {
                if (!string.IsNullOrEmpty(toolCall.Function.Arguments))
                {
                    update.Contents.Add(new FunctionCallContent(
                        callId: null,
                        name: null,
                        arguments: ParseArguments(toolCall.Function.Arguments))
                    {
                        RawRepresentation = toolCall,
                    });
                }
            }
        }
    }

    private ChatRequest CreateChatRequest(
        IEnumerable<ChatMessage> messages,
        ChatOptions? options)
    {
        var requestMessages = new List<MessagesItem>();

        if (!string.IsNullOrWhiteSpace(options?.Instructions))
        {
            requestMessages.Add(new SystemMessage
            {
                Content = options!.Instructions!,
            });
        }

        foreach (var message in messages)
        {
            requestMessages.Add(ToAi21Message(message));
        }

        var request = options?.RawRepresentationFactory?.Invoke(null!) as ChatRequest;
        if (request is null)
        {
            request = new ChatRequest
            {
                Model = ToModelName(options?.ModelId),
                Messages = requestMessages,
            };
        }
        else
        {
            request.Messages ??= [];
            foreach (var msg in requestMessages)
            {
                request.Messages.Add(msg);
            }
        }

        ApplyChatOptions(request, options);
        return request;
    }

    private static MessagesItem ToAi21Message(ChatMessage message)
    {
        if (message.Role == ChatRole.System)
        {
            return new SystemMessage
            {
                Content = string.Concat(message.Contents.OfType<TextContent>().Select(tc => tc.Text)),
            };
        }

        if (message.Role == ChatRole.Tool)
        {
            var functionResult = message.Contents.OfType<FunctionResultContent>().FirstOrDefault();
            return new ToolMessage
            {
                ToolCallId = functionResult?.CallId ?? string.Empty,
                Content = ToResultString(functionResult),
            };
        }

        if (message.Role == ChatRole.Assistant)
        {
            var toolCalls = message.Contents.OfType<FunctionCallContent>().ToList();
            var text = string.Concat(message.Contents.OfType<TextContent>().Select(tc => tc.Text));

            var assistantMessage = new AssistantMessage
            {
                Content = string.IsNullOrEmpty(text) ? null : text,
            };

            if (toolCalls.Count > 0)
            {
                assistantMessage.ToolCalls = toolCalls.Select(tc => new ToolCall
                {
                    Id = tc.CallId ?? string.Empty,
                    Function = new ToolFunction
                    {
                        Name = tc.Name,
                        Arguments = tc.Arguments is { } args
                            ? JsonSerializer.Serialize(args)
                            : "{}",
                    },
                }).ToList();
            }

            return assistantMessage;
        }

        // User message
        return new UserMessage
        {
            Content = string.Concat(message.Contents.OfType<TextContent>().Select(tc => tc.Text)),
        };
    }

    private static void ApplyChatOptions(ChatRequest request, ChatOptions? options)
    {
        if (options is null)
        {
            return;
        }

        request.Temperature ??= options.Temperature;
        request.TopP ??= options.TopP;
        request.MaxTokens ??= options.MaxOutputTokens;

        if (request.Stop is null && options.StopSequences is { Count: > 0 })
        {
            request.Stop = options.StopSequences.Count == 1
                ? new AnyOf<string, IList<string>>(options.StopSequences[0])
                : new AnyOf<string, IList<string>>(options.StopSequences.ToList());
        }

        if (request.ResponseFormat is null && options.ResponseFormat is ChatResponseFormatJson)
        {
            request.ResponseFormat = new ResponseFormat
            {
                Type = ResponseFormatType.JsonObject,
            };
        }

        ApplyTools(request, options);
    }

    private static void ApplyTools(ChatRequest request, ChatOptions options)
    {
        if (options.ToolMode is NoneChatToolMode)
        {
            return;
        }

        if (options.Tools is { Count: > 0 } aiTools)
        {
            request.Tools ??= [];
            foreach (var tool in aiTools)
            {
                if (tool is not AIFunction function)
                {
                    throw new NotSupportedException(
                        $"Tool type '{tool.GetType().Name}' is not supported by AI21. Only function tools are supported.");
                }

                request.Tools.Add(new LanguageStudioApiServerDataTypesChatToolDefinition
                {
                    Function = new FunctionToolDefinition
                    {
                        Name = function.Name,
                        Description = function.Description,
                        Parameters = new ToolParameters
                        {
                            Properties = function.JsonSchema.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined
                                ? new object()
                                : function.JsonSchema,
                        },
                    },
                });
            }
        }
    }

    private static ChatResponse CreateChatResponse(ChatCompletion completion, string? requestedModelId)
    {
        var firstChoice = completion.Choices.FirstOrDefault();
        var responseMessage = new ChatMessage
        {
            Role = ChatRole.Assistant,
            RawRepresentation = completion,
        };

        if (firstChoice?.Message is { } message)
        {
            AddAssistantContents(responseMessage.Contents, message);
        }

        return new ChatResponse(responseMessage)
        {
            ResponseId = completion.Id,
            ModelId = requestedModelId,
            FinishReason = firstChoice is not null ? ToFinishReason(firstChoice.FinishReason) : null,
            Usage = CreateUsageDetails(completion.Usage),
            RawRepresentation = completion,
        };
    }

    private static void AddAssistantContents(IList<AIContent> contents, AssistantMessage message)
    {
        if (!string.IsNullOrEmpty(message.Content))
        {
            contents.Add(new TextContent(message.Content)
            {
                RawRepresentation = message,
            });
        }

        if (!string.IsNullOrEmpty(message.ReasoningContent))
        {
            contents.Add(new TextReasoningContent(message.ReasoningContent)
            {
                RawRepresentation = message,
            });
        }

        if (message.ToolCalls is { Count: > 0 } toolCalls)
        {
            foreach (var toolCall in toolCalls)
            {
                contents.Add(new FunctionCallContent(
                    callId: toolCall.Id,
                    name: toolCall.Function.Name,
                    arguments: ParseArguments(toolCall.Function.Arguments))
                {
                    RawRepresentation = toolCall,
                });
            }
        }
    }

    private static ModelName ToModelName(string? modelId)
    {
        if (string.IsNullOrEmpty(modelId))
        {
            return ModelName.JambaLarge;
        }

        return ModelNameExtensions.ToEnum(modelId) ?? ModelName.JambaLarge;
    }

    private static Dictionary<string, object?>? ParseArguments(string? argumentsJson)
    {
        if (string.IsNullOrWhiteSpace(argumentsJson) || argumentsJson is "{}")
        {
            return null;
        }

        try
        {
            var element = JsonSerializer.Deserialize<JsonElement>(argumentsJson);
            if (element.ValueKind == JsonValueKind.Object)
            {
                var dict = new Dictionary<string, object?>(StringComparer.Ordinal);
                foreach (var property in element.EnumerateObject())
                {
                    dict[property.Name] = property.Value;
                }

                return dict;
            }
        }
        catch (JsonException)
        {
            return null;
        }

        return null;
    }

    private static string ToResultString(FunctionResultContent? functionResult)
    {
        if (functionResult is null)
        {
            return string.Empty;
        }

        if (functionResult.Result is JsonElement jsonElement)
        {
            return jsonElement.ValueKind == JsonValueKind.String
                ? jsonElement.GetString() ?? string.Empty
                : jsonElement.GetRawText();
        }

        if (functionResult.Result is string text)
        {
            return text;
        }

        if (functionResult.Result is not null)
        {
            return JsonSerializer.Serialize(functionResult.Result);
        }

        return functionResult.Exception?.Message ?? string.Empty;
    }

    private static ChatFinishReason? ToFinishReason(string? finishReason) =>
        finishReason switch
        {
            "stop" => ChatFinishReason.Stop,
            "length" => ChatFinishReason.Length,
            "tool_calls" => ChatFinishReason.ToolCalls,
            _ => null,
        };

    private static UsageDetails CreateUsageDetails(UsageInfo usage) =>
        new()
        {
            InputTokenCount = usage.PromptTokens,
            OutputTokenCount = usage.CompletionTokens,
            TotalTokenCount = usage.TotalTokens,
        };
}
