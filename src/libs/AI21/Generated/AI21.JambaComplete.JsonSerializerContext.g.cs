
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AI21
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantMessageRole), TypeInfoPropertyName = "AssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.Logprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatCompletionResponseDeltaChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta, global::AI21.ChatStreamingToolCallsFirstDelta, global::AI21.ChatStreamingToolCallsDelta>), TypeInfoPropertyName = "AnyOfChatStreamingFirstDeltaChatStreamingContentDeltaChatStreamingToolCallsFirstDeltaChatStreamingToolCallsDelta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingFirstDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingContentDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingToolCallsFirstDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingToolCallsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatCompletionVllmStreamingMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ChatCompletionResponseDeltaChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModelName), TypeInfoPropertyName = "ModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MessagesItem), TypeInfoPropertyName = "MessagesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatRequestMessageDiscriminatorRole), TypeInfoPropertyName = "ChatRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MockResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.DocumentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.DocumentSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingFirstDeltaRole), TypeInfoPropertyName = "ChatStreamingFirstDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ToolCallDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ToolCallDeltaStart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallDeltaStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.FunctionToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.LogprobsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LogprobsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.TopLogprobsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.TopLogprobsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ResponseFormatType), TypeInfoPropertyName = "ResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.SystemMessageRole), TypeInfoPropertyName = "SystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallType), TypeInfoPropertyName = "ToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolFunctionDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallDeltaStartType), TypeInfoPropertyName = "ToolCallDeltaStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolFunctionDeltaStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolMessageRole), TypeInfoPropertyName = "ToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolParametersType), TypeInfoPropertyName = "ToolParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UserMessageRole), TypeInfoPropertyName = "UserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinitionType), TypeInfoPropertyName = "LanguageStudioApiServerDataTypesChatToolDefinitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>), TypeInfoPropertyName = "AnyOfChatCompletionIListChatCompletionVllmStreamingMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AssistantMessageRole?), TypeInfoPropertyName = "NullableAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta, global::AI21.ChatStreamingToolCallsFirstDelta, global::AI21.ChatStreamingToolCallsDelta>?), TypeInfoPropertyName = "ChatStreamingToolCallsDelta_e4c511f790af3538")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ModelName?), TypeInfoPropertyName = "NullableModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.MessagesItem?), TypeInfoPropertyName = "NullableMessagesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatRequestMessageDiscriminatorRole?), TypeInfoPropertyName = "NullableChatRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ChatStreamingFirstDeltaRole?), TypeInfoPropertyName = "NullableChatStreamingFirstDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ResponseFormatType?), TypeInfoPropertyName = "NullableResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.SystemMessageRole?), TypeInfoPropertyName = "NullableSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallType?), TypeInfoPropertyName = "NullableToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolCallDeltaStartType?), TypeInfoPropertyName = "NullableToolCallDeltaStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolMessageRole?), TypeInfoPropertyName = "NullableToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.ToolParametersType?), TypeInfoPropertyName = "NullableToolParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.UserMessageRole?), TypeInfoPropertyName = "NullableUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinitionType?), TypeInfoPropertyName = "NullableLanguageStudioApiServerDataTypesChatToolDefinitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>?), TypeInfoPropertyName = "NullableAnyOfChatCompletionIListChatCompletionVllmStreamingMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ChatCompletionResponseDeltaChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.LanguageStudioApiServerDataTypesChatToolDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.DocumentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ToolCallDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ToolCallDeltaStart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.LogprobsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.TopLogprobsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.AnyOf<global::AI21.ChatCompletion, global::System.Collections.Generic.List<global::AI21.ChatCompletionVllmStreamingMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AI21.ChatCompletionVllmStreamingMessage>))]
    internal sealed partial class JambaCompleteSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JambaCompleteSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static JambaCompleteSourceGenerationContext Default { get; } = new(DefaultOptions);

        private JambaCompleteSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::AI21.JsonConverters.MessagesItemJsonConverter());
            options.Converters.Add(new global::AI21.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::AI21.JsonConverters.AnyOfJsonConverter<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta, global::AI21.ChatStreamingToolCallsFirstDelta, global::AI21.ChatStreamingToolCallsDelta>());
            options.Converters.Add(new global::AI21.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::AI21.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::AI21.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::AI21.JsonConverters.AnyOfJsonConverter<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>());
            options.Converters.Add(new global::AI21.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AI21.AssistantMessageRole)

                    || typeToConvert == typeof(global::AI21.AssistantMessageRole?)

                    || typeToConvert == typeof(global::AI21.ChatRequestMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::AI21.ChatRequestMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::AI21.ChatStreamingFirstDeltaRole)

                    || typeToConvert == typeof(global::AI21.ChatStreamingFirstDeltaRole?)

                    || typeToConvert == typeof(global::AI21.ModelName)

                    || typeToConvert == typeof(global::AI21.ModelName?)

                    || typeToConvert == typeof(global::AI21.ResponseFormatType)

                    || typeToConvert == typeof(global::AI21.ResponseFormatType?)

                    || typeToConvert == typeof(global::AI21.SystemMessageRole)

                    || typeToConvert == typeof(global::AI21.SystemMessageRole?)

                    || typeToConvert == typeof(global::AI21.ToolCallType)

                    || typeToConvert == typeof(global::AI21.ToolCallType?)

                    || typeToConvert == typeof(global::AI21.ToolCallDeltaStartType)

                    || typeToConvert == typeof(global::AI21.ToolCallDeltaStartType?)

                    || typeToConvert == typeof(global::AI21.ToolMessageRole)

                    || typeToConvert == typeof(global::AI21.ToolMessageRole?)

                    || typeToConvert == typeof(global::AI21.ToolParametersType)

                    || typeToConvert == typeof(global::AI21.ToolParametersType?)

                    || typeToConvert == typeof(global::AI21.UserMessageRole)

                    || typeToConvert == typeof(global::AI21.UserMessageRole?)

                    || typeToConvert == typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinitionType)

                    || typeToConvert == typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinitionType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AI21.AssistantMessageRole))
                {
                    return new global::AI21.JsonConverters.AssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.AssistantMessageRole?))
                {
                    return new global::AI21.JsonConverters.AssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ChatRequestMessageDiscriminatorRole))
                {
                    return new global::AI21.JsonConverters.ChatRequestMessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ChatRequestMessageDiscriminatorRole?))
                {
                    return new global::AI21.JsonConverters.ChatRequestMessageDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ChatStreamingFirstDeltaRole))
                {
                    return new global::AI21.JsonConverters.ChatStreamingFirstDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ChatStreamingFirstDeltaRole?))
                {
                    return new global::AI21.JsonConverters.ChatStreamingFirstDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ModelName))
                {
                    return new global::AI21.JsonConverters.ModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ModelName?))
                {
                    return new global::AI21.JsonConverters.ModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ResponseFormatType))
                {
                    return new global::AI21.JsonConverters.ResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ResponseFormatType?))
                {
                    return new global::AI21.JsonConverters.ResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.SystemMessageRole))
                {
                    return new global::AI21.JsonConverters.SystemMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.SystemMessageRole?))
                {
                    return new global::AI21.JsonConverters.SystemMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ToolCallType))
                {
                    return new global::AI21.JsonConverters.ToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ToolCallType?))
                {
                    return new global::AI21.JsonConverters.ToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ToolCallDeltaStartType))
                {
                    return new global::AI21.JsonConverters.ToolCallDeltaStartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ToolCallDeltaStartType?))
                {
                    return new global::AI21.JsonConverters.ToolCallDeltaStartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ToolMessageRole))
                {
                    return new global::AI21.JsonConverters.ToolMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ToolMessageRole?))
                {
                    return new global::AI21.JsonConverters.ToolMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ToolParametersType))
                {
                    return new global::AI21.JsonConverters.ToolParametersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.ToolParametersType?))
                {
                    return new global::AI21.JsonConverters.ToolParametersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.UserMessageRole))
                {
                    return new global::AI21.JsonConverters.UserMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.UserMessageRole?))
                {
                    return new global::AI21.JsonConverters.UserMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinitionType))
                {
                    return new global::AI21.JsonConverters.LanguageStudioApiServerDataTypesChatToolDefinitionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AI21.LanguageStudioApiServerDataTypesChatToolDefinitionType?))
                {
                    return new global::AI21.JsonConverters.LanguageStudioApiServerDataTypesChatToolDefinitionTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new JambaCompleteSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}