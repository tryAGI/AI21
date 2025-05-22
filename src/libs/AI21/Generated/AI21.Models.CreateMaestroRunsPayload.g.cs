
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
        public global::System.Collections.Generic.IList<global::AI21.OutputOptions>? Include { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_rag_enabled")]
        public bool? StructuredRagEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools_allowed")]
        public bool? ToolsAllowed { get; set; }

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
        /// <param name="toolsAllowed">
        /// Default Value: false
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
            global::System.Collections.Generic.IList<global::AI21.OutputOptions>? include,
            bool? structuredRagEnabled,
            bool? toolsAllowed)
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
            this.ToolsAllowed = toolsAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMaestroRunsPayload" /> class.
        /// </summary>
        public CreateMaestroRunsPayload()
        {
        }
    }
}