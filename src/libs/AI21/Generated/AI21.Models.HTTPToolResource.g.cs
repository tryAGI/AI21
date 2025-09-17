
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HTTPToolResource
    {
        /// <summary>
        /// Default Value: http
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.HTTPToolResourceTypeJsonConverter))]
        public global::AI21.HTTPToolResourceType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.HTTPToolFunction Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.HTTPToolEndpoint Endpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPToolResource" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: http
        /// </param>
        /// <param name="function"></param>
        /// <param name="endpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HTTPToolResource(
            global::AI21.HTTPToolFunction function,
            global::AI21.HTTPToolEndpoint endpoint,
            global::AI21.HTTPToolResourceType? type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPToolResource" /> class.
        /// </summary>
        public HTTPToolResource()
        {
        }
    }
}