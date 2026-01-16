
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyAssistantRequest
    {
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
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.RunOptimizationJsonConverter))]
        public global::AI21.RunOptimization? Optimization { get; set; }

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
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.AssistantTool2>>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        public global::AI21.AssistantToolResource? ToolResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>? Requirements { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.BudgetLevelJsonConverter))]
        public global::AI21.BudgetLevel? Budget { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.VisibilityJsonConverter))]
        public global::AI21.Visibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="optimization">
        /// An enumeration.
        /// </param>
        /// <param name="avatar"></param>
        /// <param name="isArchived">
        /// Default Value: false
        /// </param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="requirements"></param>
        /// <param name="budget">
        /// An enumeration.
        /// </param>
        /// <param name="visibility">
        /// An enumeration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModifyAssistantRequest(
            string? name,
            string? description,
            global::AI21.RunOptimization? optimization,
            string? avatar,
            bool? isArchived,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::AI21.AssistantTool2>>? tools,
            global::AI21.AssistantToolResource? toolResources,
            global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesAssistantRequirement>? requirements,
            global::AI21.BudgetLevel? budget,
            global::AI21.Visibility? visibility)
        {
            this.Name = name;
            this.Description = description;
            this.Optimization = optimization;
            this.Avatar = avatar;
            this.IsArchived = isArchived;
            this.Models = models;
            this.Tools = tools;
            this.ToolResources = toolResources;
            this.Requirements = requirements;
            this.Budget = budget;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequest" /> class.
        /// </summary>
        public ModifyAssistantRequest()
        {
        }
    }
}