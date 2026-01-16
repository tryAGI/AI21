
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPDefinition" /> class.
        /// </summary>
        /// <param name="serverUrl"></param>
        /// <param name="serverLabel"></param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPDefinition(
            string serverUrl,
            string? serverLabel,
            object? headers)
        {
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.ServerLabel = serverLabel;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPDefinition" /> class.
        /// </summary>
        public MCPDefinition()
        {
        }
    }
}