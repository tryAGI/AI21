
#nullable enable

namespace AI21
{
    /// <summary>
    /// Body for ``POST /tokenwise/settings/agents``.
    /// </summary>
    public sealed partial class AgentCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Default Value: other
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreate" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="kind">
        /// Default Value: other
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="configId"></param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCreate(
            string agentId,
            string? kind,
            string? name,
            string? description,
            string? configId,
            bool? enabled)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Kind = kind;
            this.Name = name;
            this.Description = description;
            this.ConfigId = configId;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreate" /> class.
        /// </summary>
        public AgentCreate()
        {
        }

    }
}