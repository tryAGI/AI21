
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMaestroRunsPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::AI21.Message>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string> Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_type")]
        public object? OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.CreateMaestroRunsPayloadTool2>>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        public global::AI21.ToolResources? ToolResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<global::AI21.Requirement>? Requirements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadBudgetJsonConverter))]
        public global::AI21.CreateMaestroRunsPayloadBudget? Budget { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// 
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
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools_allowed")]
        public bool? ToolsAllowed { get; set; }

        /// <summary>
        /// Default Value: maestro_run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.MaestroPayloadTypeJsonConverter))]
        public global::AI21.MaestroPayloadType? PayloadType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_retrieval_configs")]
        public global::System.Collections.Generic.IList<object>? CustomRetrievalConfigs { get; set; }

        /// <summary>
        /// Default Value: english
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadResponseLanguageJsonConverter))]
        public global::AI21.CreateMaestroRunsPayloadResponseLanguage? ResponseLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMaestroRunsPayload" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="outputType"></param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="context"></param>
        /// <param name="requirements"></param>
        /// <param name="budget"></param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
        /// <param name="include"></param>
        /// <param name="structuredRagEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="dynamicPlanningEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="toolsAllowed">
        /// Default Value: false
        /// </param>
        /// <param name="payloadType">
        /// Default Value: maestro_run
        /// </param>
        /// <param name="customRetrievalConfigs"></param>
        /// <param name="responseLanguage">
        /// Default Value: english
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMaestroRunsPayload(
            global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string> input,
            object? outputType,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.CreateMaestroRunsPayloadTool2>>? tools,
            global::AI21.ToolResources? toolResources,
            object? context,
            global::System.Collections.Generic.IList<global::AI21.Requirement>? requirements,
            global::AI21.CreateMaestroRunsPayloadBudget? budget,
            bool? verbose,
            global::System.Collections.Generic.IList<string>? include,
            bool? structuredRagEnabled,
            bool? dynamicPlanningEnabled,
            bool? toolsAllowed,
            global::AI21.MaestroPayloadType? payloadType,
            global::System.Collections.Generic.IList<object>? customRetrievalConfigs,
            global::AI21.CreateMaestroRunsPayloadResponseLanguage? responseLanguage)
        {
            this.Input = input;
            this.OutputType = outputType;
            this.Models = models;
            this.Tools = tools;
            this.ToolResources = toolResources;
            this.Context = context;
            this.Requirements = requirements;
            this.Budget = budget;
            this.Verbose = verbose;
            this.Include = include;
            this.StructuredRagEnabled = structuredRagEnabled;
            this.DynamicPlanningEnabled = dynamicPlanningEnabled;
            this.ToolsAllowed = toolsAllowed;
            this.PayloadType = payloadType;
            this.CustomRetrievalConfigs = customRetrievalConfigs;
            this.ResponseLanguage = responseLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMaestroRunsPayload" /> class.
        /// </summary>
        public CreateMaestroRunsPayload()
        {
        }
    }
}