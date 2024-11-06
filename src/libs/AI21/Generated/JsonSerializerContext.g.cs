
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
            typeof(global::AI21.JsonConverters.AnswerLengthJsonConverter),
            typeof(global::AI21.JsonConverters.AnswerLengthNullableJsonConverter),
            typeof(global::AI21.JsonConverters.AssistantMessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.AssistantMessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ToolCallTypeJsonConverter),
            typeof(global::AI21.JsonConverters.ToolCallTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ChatStreamingFirstDeltaRoleJsonConverter),
            typeof(global::AI21.JsonConverters.ChatStreamingFirstDeltaRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.RoleTypeJsonConverter),
            typeof(global::AI21.JsonConverters.RoleTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ConnectorsWorkflowStatusJsonConverter),
            typeof(global::AI21.JsonConverters.ConnectorsWorkflowStatusNullableJsonConverter),
            typeof(global::AI21.JsonConverters.MessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.MessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ConversationalRagConfigRetrievalStrategyJsonConverter),
            typeof(global::AI21.JsonConverters.ConversationalRagConfigRetrievalStrategyNullableJsonConverter),
            typeof(global::AI21.JsonConverters.CustomModelTypeJsonConverter),
            typeof(global::AI21.JsonConverters.CustomModelTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.DocumentTypeJsonConverter),
            typeof(global::AI21.JsonConverters.DocumentTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.FileStatusJsonConverter),
            typeof(global::AI21.JsonConverters.FileStatusNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ToolParametersTypeJsonConverter),
            typeof(global::AI21.JsonConverters.ToolParametersTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.LibraryAnswerRequestLabelsFilterModeJsonConverter),
            typeof(global::AI21.JsonConverters.LibraryAnswerRequestLabelsFilterModeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ModeJsonConverter),
            typeof(global::AI21.JsonConverters.ModeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.RetrievalStrategyJsonConverter),
            typeof(global::AI21.JsonConverters.RetrievalStrategyNullableJsonConverter),
            typeof(global::AI21.JsonConverters.LibrarySearchRequestLabelsFilterModeJsonConverter),
            typeof(global::AI21.JsonConverters.LibrarySearchRequestLabelsFilterModeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ModelNameJsonConverter),
            typeof(global::AI21.JsonConverters.ModelNameNullableJsonConverter),
            typeof(global::AI21.JsonConverters.StyleTypeJsonConverter),
            typeof(global::AI21.JsonConverters.StyleTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ResponseFormatTypeJsonConverter),
            typeof(global::AI21.JsonConverters.ResponseFormatTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.SummaryMethodJsonConverter),
            typeof(global::AI21.JsonConverters.SummaryMethodNullableJsonConverter),
            typeof(global::AI21.JsonConverters.SystemMessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.SystemMessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ToolDefinitionTypeJsonConverter),
            typeof(global::AI21.JsonConverters.ToolDefinitionTypeNullableJsonConverter),
            typeof(global::AI21.JsonConverters.ToolMessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.ToolMessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.UserMessageRoleJsonConverter),
            typeof(global::AI21.JsonConverters.UserMessageRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleJsonConverter),
            typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleNullableJsonConverter),
            typeof(global::AI21.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::AI21.JsonConverters.QueryFilterJsonConverter),
            typeof(global::AI21.JsonConverters.MessagesItemJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}