
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
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement>? Requirements { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_id")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Default Value: main
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadVariantJsonConverter))]
        public global::AI21.CreateMaestroRunsPayloadVariant? Variant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_retrieval_configs")]
        public global::System.Collections.Generic.IList<object>? CustomRetrievalConfigs { get; set; }

        /// <summary>
        /// Default Value: unset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.CreateMaestroRunsPayloadResponseLanguageJsonConverter))]
        public global::AI21.CreateMaestroRunsPayloadResponseLanguage? ResponseLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Whether or not to stream the result one token at a time using<br/>
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events).<br/>
        /// This can be useful when waiting for long results where a long wait time for an<br/>
        /// answer can be problematic, such as a chatbot. If set to `True`, then `n` must<br/>
        /// be 1. A streaming response is different than the non-streaming response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

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
        /// <param name="assistantId"></param>
        /// <param name="variant">
        /// Default Value: main
        /// </param>
        /// <param name="customRetrievalConfigs"></param>
        /// <param name="responseLanguage">
        /// Default Value: unset
        /// </param>
        /// <param name="systemPrompt"></param>
        /// <param name="stream">
        /// Whether or not to stream the result one token at a time using<br/>
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events).<br/>
        /// This can be useful when waiting for long results where a long wait time for an<br/>
        /// answer can be problematic, such as a chatbot. If set to `True`, then `n` must<br/>
        /// be 1. A streaming response is different than the non-streaming response.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMaestroRunsPayload(
            global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string> input,
            object? outputType,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>? tools,
            object? context,
            global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement>? requirements,
            global::AI21.CreateMaestroRunsPayloadBudget? budget,
            bool? verbose,
            global::System.Collections.Generic.IList<string>? include,
            bool? structuredRagEnabled,
            bool? dynamicPlanningEnabled,
            string? assistantId,
            global::AI21.CreateMaestroRunsPayloadVariant? variant,
            global::System.Collections.Generic.IList<object>? customRetrievalConfigs,
            global::AI21.CreateMaestroRunsPayloadResponseLanguage? responseLanguage,
            string? systemPrompt,
            bool? stream)
        {
            this.Input = input;
            this.OutputType = outputType;
            this.Models = models;
            this.Tools = tools;
            this.Context = context;
            this.Requirements = requirements;
            this.Budget = budget;
            this.Verbose = verbose;
            this.Include = include;
            this.StructuredRagEnabled = structuredRagEnabled;
            this.DynamicPlanningEnabled = dynamicPlanningEnabled;
            this.AssistantId = assistantId;
            this.Variant = variant;
            this.CustomRetrievalConfigs = customRetrievalConfigs;
            this.ResponseLanguage = responseLanguage;
            this.SystemPrompt = systemPrompt;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMaestroRunsPayload" /> class.
        /// </summary>
        public CreateMaestroRunsPayload()
        {
        }
    }
}