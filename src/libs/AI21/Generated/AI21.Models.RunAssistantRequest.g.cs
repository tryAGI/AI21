
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunAssistantRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.Message> Input { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_type")]
        public object? OutputType { get; set; }

        /// <summary>
        /// Default Value: [data_sources, requirements_result, requirements_result.metadata]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_rag_enabled")]
        public bool? StructuredRagEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_planning_enabled")]
        public bool? DynamicPlanningEnabled { get; set; }

        /// <summary>
        /// Default Value: unset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.RunAssistantRequestResponseLanguageJsonConverter))]
        public global::AI21.RunAssistantRequestResponseLanguage? ResponseLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAssistantRequest" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
        /// <param name="outputType"></param>
        /// <param name="include">
        /// Default Value: [data_sources, requirements_result, requirements_result.metadata]
        /// </param>
        /// <param name="structuredRagEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="dynamicPlanningEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="responseLanguage">
        /// Default Value: unset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunAssistantRequest(
            global::System.Collections.Generic.IList<global::AI21.Message> input,
            bool? verbose,
            object? outputType,
            global::System.Collections.Generic.IList<string>? include,
            bool? structuredRagEnabled,
            bool? dynamicPlanningEnabled,
            global::AI21.RunAssistantRequestResponseLanguage? responseLanguage)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Verbose = verbose;
            this.OutputType = outputType;
            this.Include = include;
            this.StructuredRagEnabled = structuredRagEnabled;
            this.DynamicPlanningEnabled = dynamicPlanningEnabled;
            this.ResponseLanguage = responseLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAssistantRequest" /> class.
        /// </summary>
        public RunAssistantRequest()
        {
        }
    }
}