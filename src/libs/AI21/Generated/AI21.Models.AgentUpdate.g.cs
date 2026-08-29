
#nullable enable

namespace AI21
{
    /// <summary>
    /// Body for ``PUT /tokenwise/settings/agents/{agent_id}`` — partial update.
    /// </summary>
    public sealed partial class AgentUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public string? ConfigId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="description"></param>
        /// <param name="configId"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUpdate(
            string? name,
            string? kind,
            string? description,
            string? configId,
            bool? enabled)
        {
            this.Name = name;
            this.Kind = kind;
            this.Description = description;
            this.ConfigId = configId;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdate" /> class.
        /// </summary>
        public AgentUpdate()
        {
        }

    }
}