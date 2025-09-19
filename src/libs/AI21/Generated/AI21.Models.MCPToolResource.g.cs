
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolResource
    {
        /// <summary>
        /// Default Value: mcp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.MCPToolResourceTypeJsonConverter))]
        public global::AI21.MCPToolResourceType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolResource" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
        /// <param name="serverLabel"></param>
        /// <param name="serverUrl"></param>
        /// <param name="headers"></param>
        /// <param name="allowedTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolResource(
            string serverLabel,
            string serverUrl,
            global::AI21.MCPToolResourceType? type,
            object? headers,
            global::System.Collections.Generic.IList<string>? allowedTools)
        {
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.Type = type;
            this.Headers = headers;
            this.AllowedTools = allowedTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolResource" /> class.
        /// </summary>
        public MCPToolResource()
        {
        }
    }
}