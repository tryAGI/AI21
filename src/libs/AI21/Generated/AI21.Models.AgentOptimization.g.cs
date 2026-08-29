
#nullable enable

namespace AI21
{
    /// <summary>
    /// Response shape for one card in ``GET /tokenwise/settings/agents/{agent_id}/optimizations``.<br/>
    /// String-ish fields stay plain ``str`` (not ``Literal``) so a new gateway enum<br/>
    /// value (a new ``availability`` / ``safety`` / ``category``) doesn't force an<br/>
    /// api-server release. The gateway filters ``hidden`` cards, so we never see them.
    /// </summary>
    public sealed partial class AgentOptimization
    {
        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Availability { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Safety { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOptimization" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="keys"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="category"></param>
        /// <param name="availability"></param>
        /// <param name="safety"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOptimization(
            string id,
            global::System.Collections.Generic.IList<string> keys,
            string name,
            string description,
            string category,
            string availability,
            string safety)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Availability = availability ?? throw new global::System.ArgumentNullException(nameof(availability));
            this.Safety = safety ?? throw new global::System.ArgumentNullException(nameof(safety));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOptimization" /> class.
        /// </summary>
        public AgentOptimization()
        {
        }

    }
}