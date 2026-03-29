
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Assistant
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

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
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimization")]
        public string? Optimization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>))]
        public global::AI21.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>? Requirements { get; set; }

        /// <summary>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.BudgetLevelJsonConverter))]
        public global::AI21.BudgetLevel? Budget { get; set; }

        /// <summary>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.VisibilityJsonConverter))]
        public global::AI21.Visibility? Visibility { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.AssistantTypeJsonConverter))]
        public global::AI21.AssistantType? AssistantType { get; set; }

        /// <summary>
        /// Default Value: unset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.AssistantResponseLanguageJsonConverter))]
        public global::AI21.AssistantResponseLanguage? ResponseLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vibe_prompt")]
        public string? VibePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starter_questions")]
        public global::System.Collections.Generic.IList<global::AI21.StarterQuestion>? StarterQuestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_config")]
        public global::AI21.WorkflowConfig? WorkflowConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_overrides")]
        public object? ConfigOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Assistant" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="object"></param>
        /// <param name="name"></param>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="description"></param>
        /// <param name="optimization"></param>
        /// <param name="workspaceId"></param>
        /// <param name="avatar"></param>
        /// <param name="isArchived">
        /// Default Value: false
        /// </param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="requirements"></param>
        /// <param name="budget">
        /// Default Value: medium
        /// </param>
        /// <param name="visibility">
        /// Default Value: public
        /// </param>
        /// <param name="assistantType">
        /// Default Value: default
        /// </param>
        /// <param name="responseLanguage">
        /// Default Value: unset
        /// </param>
        /// <param name="vibePrompt"></param>
        /// <param name="starterQuestions"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="workflowConfig"></param>
        /// <param name="configOverrides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Assistant(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string @object,
            string name,
            string organizationId,
            string userId,
            string? description,
            string? optimization,
            string? workspaceId,
            string? avatar,
            bool? isArchived,
            global::AI21.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<string>>? models,
            global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineToolDefinition>? tools,
            global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>? requirements,
            global::AI21.BudgetLevel? budget,
            global::AI21.Visibility? visibility,
            global::AI21.AssistantType? assistantType,
            global::AI21.AssistantResponseLanguage? responseLanguage,
            string? vibePrompt,
            global::System.Collections.Generic.IList<global::AI21.StarterQuestion>? starterQuestions,
            string? systemPrompt,
            global::AI21.WorkflowConfig? workflowConfig,
            object? configOverrides)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Optimization = optimization;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.WorkspaceId = workspaceId;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Avatar = avatar;
            this.IsArchived = isArchived;
            this.Models = models;
            this.Tools = tools;
            this.Requirements = requirements;
            this.Budget = budget;
            this.Visibility = visibility;
            this.AssistantType = assistantType;
            this.ResponseLanguage = responseLanguage;
            this.VibePrompt = vibePrompt;
            this.StarterQuestions = starterQuestions;
            this.SystemPrompt = systemPrompt;
            this.WorkflowConfig = workflowConfig;
            this.ConfigOverrides = configOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Assistant" /> class.
        /// </summary>
        public Assistant()
        {
        }
    }
}