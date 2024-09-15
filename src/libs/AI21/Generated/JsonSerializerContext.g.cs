
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
            typeof(global::OpenApiGenerator.JsonConverters.AnswerLengthJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AnswerLengthNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AssistantMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AssistantMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolCallTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolCallTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatStreamingFirstDeltaRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatStreamingFirstDeltaRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RoleTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RoleTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ConversationalRagConfigRetrievalStrategyJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ConversationalRagConfigRetrievalStrategyNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CorrectionTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CorrectionTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CustomModelTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CustomModelTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DocumentTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DocumentTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.EmbedTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.EmbedTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FileStatusJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FileStatusNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolParametersTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolParametersTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RunStatusJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RunStatusNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RunOptimizationJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RunOptimizationNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LibraryAnswerRequestLabelsFilterModeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LibraryAnswerRequestLabelsFilterModeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RetrievalStrategy3JsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RetrievalStrategy3NullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LibrarySearchRequestLabelsFilterModeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LibrarySearchRequestLabelsFilterModeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelNameJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelNameNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.StyleTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.StyleTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ResponseFormatTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ResponseFormatTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SummaryMethodJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SummaryMethodNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SystemMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SystemMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolDefinitionTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolDefinitionTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.UserMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.UserMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1),
            typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory4),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AI21.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}