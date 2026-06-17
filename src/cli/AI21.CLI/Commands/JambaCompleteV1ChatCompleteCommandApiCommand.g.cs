#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class JambaCompleteV1ChatCompleteCommandApiCommand
{
    private static Option<global::AI21.ModelName> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The name of the model to use. Choose one of the following values:
* `jamba-instruct-preview`
",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::AI21.MessagesItem>> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"The previous messages in this chat, from oldest (index 0) to newest. Messages
must be alternating `user`/`assistant` messages, optionally starting with a `system`
message. For single turn interactions, this should be an optional `system` message,
and a single `user` message. Maximum total size for the list is about 256K tokens.
",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"",
    };

    private static Option<int?> N { get; } = new(
        name: @"--n")
    {
        Description = @"How many chat responses to generate. _Range: 1 – 16_ **Notes:**
- If `n > 1`, setting `temperature=0` will fail because all answers are guaranteed to be duplicates.
- `n` must be 1 when `stream = True`
",
    };

    private static Option<int?> MaxTokens { get; } = new(
        name: @"--max-tokens")
    {
        Description = @"The maximum number of tokens to allow for each generated response message. Typically
the best way to limit output length is by providing a length limit in the system
prompt (for example, ""limit your answers to three sentences""). _Range: 0 – 4096_
",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"How much variation to provide in each answer. Setting this value to 0 guarantees the
same response to the same question every time. Setting a higher value encourages more
variation. Modifies the distribution from which tokens are sampled.
[More information](https://docs.ai21.com/docs/sampling-from-language-models#temperature)
_Range: 0.0 – 2.0_
",
    };

    private static Option<double?> TopP { get; } = new(
        name: @"--top-p")
    {
        Description = @"Limit the pool of next tokens in each step to the top N percentile of possible
tokens, where 1.0 means the pool of all possible tokens, and 0.01 means the
pool of only the most likely next tokens. [More information]
(https://docs.ai21.com/docs/sampling-from-language-models#topp) _Range: 0 \<= value \<=1.0_
",
    };

    private static Option<global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
        name: @"--stop")
    {
        Description = @"End the message when the model generates one of these strings. The stop sequence
is not included in the generated message. Each sequence can be up to 64K long, and
can contain newlines as `\n` characters. Examples:
- Single stop string with a word and a period: ""monkeys.""
- Multiple stop strings and a newline: [""cat"", ""dog"", "" ."", ""####"", ""\n""]
",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"Whether or not to stream the result one token at a time using
[server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events).
This can be useful when waiting for long results where a long wait time for an
answer can be problematic, such as a chatbot. If set to `True`, then `n` must
be 1. A streaming response is different than the non-streaming response.
");

    private static Option<global::AI21.MockResponseConfig?> MockResponse { get; } = new(
        name: @"--mock-response")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::AI21.DocumentSchema>?> Documents { get; } = new(
        name: @"--documents")
    {
        Description = @"",
    };

    private static Option<global::AI21.ResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"v1-chat-complete", @"Studio Chat Complete
This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).
This is a foundation model that supports both single-turn (question answering,
text completion) and multi-turn (chat style) interactions.

You can optionally stream results if you want to get the response as each
token is generated, rather than waiting for the entire response.");
                        command.Options.Add(Model);
                        command.Options.Add(Messages);
                        command.Options.Add(Tools);
                        command.Options.Add(N);
                        command.Options.Add(MaxTokens);
                        command.Options.Add(Temperature);
                        command.Options.Add(TopP);
                        command.Options.Add(Stop);
                        command.Options.Add(Stream);
                        command.Options.Add(MockResponse);
                        command.Options.Add(Documents);
                        command.Options.Add(ResponseFormat);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.ChatRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var messages = parseResult.GetRequiredValue(Messages);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var n = CliRuntime.WasSpecified(parseResult, N) ? parseResult.GetValue(N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var maxTokens = CliRuntime.WasSpecified(parseResult, MaxTokens) ? parseResult.GetValue(MaxTokens) : (__requestBase is { } __MaxTokensBaseValue ? __MaxTokensBaseValue.MaxTokens : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, TopP) ? parseResult.GetValue(TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var stop = CliRuntime.WasSpecified(parseResult, Stop) ? parseResult.GetValue(Stop) : (__requestBase is { } __StopBaseValue ? __StopBaseValue.Stop : default);
                        var stream = CliRuntime.WasSpecified(parseResult, Stream) ? parseResult.GetValue(Stream) : (__requestBase is { } __StreamBaseValue ? __StreamBaseValue.Stream : default);
                        var mockResponse = CliRuntime.WasSpecified(parseResult, MockResponse) ? parseResult.GetValue(MockResponse) : (__requestBase is { } __MockResponseBaseValue ? __MockResponseBaseValue.MockResponse : default);
                        var documents = CliRuntime.WasSpecified(parseResult, Documents) ? parseResult.GetValue(Documents) : (__requestBase is { } __DocumentsBaseValue ? __DocumentsBaseValue.Documents : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.JambaComplete.V1ChatCompleteAsync(
                                    model: model,
                                    messages: messages,
                                    tools: tools,
                                    n: n,
                                    maxTokens: maxTokens,
                                    temperature: temperature,
                                    topP: topP,
                                    stop: stop,
                                    stream: stream,
                                    mockResponse: mockResponse,
                                    documents: documents,
                                    responseFormat: responseFormat,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AI21.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}