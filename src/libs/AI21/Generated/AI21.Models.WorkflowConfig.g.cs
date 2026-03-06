
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_params")]
        public object? AdditionalParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowConfig" /> class.
        /// </summary>
        /// <param name="endpointUrl"></param>
        /// <param name="headers"></param>
        /// <param name="additionalParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowConfig(
            string endpointUrl,
            object? headers,
            object? additionalParams)
        {
            this.EndpointUrl = endpointUrl ?? throw new global::System.ArgumentNullException(nameof(endpointUrl));
            this.Headers = headers;
            this.AdditionalParams = additionalParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowConfig" /> class.
        /// </summary>
        public WorkflowConfig()
        {
        }
    }
}