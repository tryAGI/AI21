
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStatelessRunsPayload
    {
        /// <summary>
        /// messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.Message> Messages { get; set; }

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
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        public global::AI21.AssistantToolResource? ToolResources { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constraints")]
        public global::System.Collections.Generic.IList<global::AI21.Constraint>? Constraints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStatelessRunsPayload" /> class.
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="outputType"></param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
        /// <param name="context"></param>
        /// <param name="constraints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStatelessRunsPayload(
            global::System.Collections.Generic.IList<global::AI21.Message> messages,
            object? outputType,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<object>? tools,
            global::AI21.AssistantToolResource? toolResources,
            bool? verbose,
            object? context,
            global::System.Collections.Generic.IList<global::AI21.Constraint>? constraints)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.OutputType = outputType;
            this.Models = models;
            this.Tools = tools;
            this.ToolResources = toolResources;
            this.Verbose = verbose;
            this.Context = context;
            this.Constraints = constraints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStatelessRunsPayload" /> class.
        /// </summary>
        public CreateStatelessRunsPayload()
        {
        }
    }
}