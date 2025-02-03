
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
            typeof(global::AI21.JsonConverters.AssistantTool2JsonConverter),
            typeof(global::AI21.JsonConverters.AssistantTool2NullableJsonConverter),
            typeof(global::AI21.JsonConverters.AssistantMessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.AssistantMessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ToolCallTypeJsonConverter),
            typeof(global::AI21.JsonConverters.ToolCallTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ChatStreamingFirstDeltaRoleJsonConverter),
            typeof(global::AI21.JsonConverters.ChatStreamingFirstDeltaRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ModelNameJsonConverter),
            typeof(global::AI21.JsonConverters.ModelNameNullableJsonConverter),
            typeof(global::AI21.JsonConverters.UserMessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.UserMessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ToolMessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.ToolMessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.SystemMessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.SystemMessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ChatRequestMessageDiscriminatorRoleJsonConverter),
            typeof(global::AI21.JsonConverters.ChatRequestMessageDiscriminatorRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ToolDefinitionTypeJsonConverter),
            typeof(global::AI21.JsonConverters.ToolDefinitionTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ToolParametersTypeJsonConverter),
            typeof(global::AI21.JsonConverters.ToolParametersTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ResponseFormatTypeJsonConverter),
            typeof(global::AI21.JsonConverters.ResponseFormatTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ConnectorsWorkflowStatusJsonConverter),
            typeof(global::AI21.JsonConverters.ConnectorsWorkflowStatusNullableJsonConverter),
            typeof(global::AI21.JsonConverters.MessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.MessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ConversationalRagConfigRetrievalStrategyJsonConverter),
            typeof(global::AI21.JsonConverters.ConversationalRagConfigRetrievalStrategyNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ConversationalRagConfigResponseLanguageJsonConverter),
            typeof(global::AI21.JsonConverters.ConversationalRagConfigResponseLanguageNullableJsonConverter),
            typeof(global::AI21.JsonConverters.FileStatusJsonConverter),
            typeof(global::AI21.JsonConverters.FileStatusNullableJsonConverter),
            typeof(global::AI21.JsonConverters.LibrarySearchRequestLabelsFilterModeJsonConverter),
            typeof(global::AI21.JsonConverters.LibrarySearchRequestLabelsFilterModeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.RetrievalStrategyJsonConverter),
            typeof(global::AI21.JsonConverters.RetrievalStrategyNullableJsonConverter),
            typeof(global::AI21.JsonConverters.MessagesItemJsonConverter),
            typeof(global::AI21.JsonConverters.QueryFilterJsonConverter),
            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>),
            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::AI21.ChatStreamingFirstDelta, global::AI21.ChatStreamingContentDelta>),
            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::AI21.ChatCompletion, global::System.Collections.Generic.IList<global::AI21.ChatCompletionVllmStreamingMessage>>),
            typeof(global::AI21.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}