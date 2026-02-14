
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorTypeJsonConverter))]
        public global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminator(
            global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminator" /> class.
        /// </summary>
        public LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminator()
        {
        }
    }
}