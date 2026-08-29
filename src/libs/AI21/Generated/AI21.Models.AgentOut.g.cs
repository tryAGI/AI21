
#nullable enable

namespace AI21
{
    /// <summary>
    /// Response shape for agent GET / POST / PUT.
    /// </summary>
    public sealed partial class AgentOut
    {
        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Used { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_user_id")]
        public string? CreatedByUserId { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_edit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOut" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="enabled"></param>
        /// <param name="used"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="configId"></param>
        /// <param name="createdByUserId"></param>
        /// <param name="canEdit">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOut(
            global::System.Guid id,
            global::System.Guid workspaceId,
            string agentId,
            string name,
            string kind,
            bool enabled,
            bool used,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? configId,
            string? createdByUserId,
            bool? canEdit)
        {
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Description = description;
            this.ConfigId = configId;
            this.Enabled = enabled;
            this.Used = used;
            this.CreatedByUserId = createdByUserId;
            this.CanEdit = canEdit;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOut" /> class.
        /// </summary>
        public AgentOut()
        {
        }

    }
}