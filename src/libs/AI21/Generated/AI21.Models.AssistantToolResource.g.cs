
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantToolResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public object? FileSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public object? WebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_approval")]
        public object? PlanApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolResource" /> class.
        /// </summary>
        /// <param name="fileSearch"></param>
        /// <param name="webSearch"></param>
        /// <param name="planApproval"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AssistantToolResource(
            object? fileSearch,
            object? webSearch,
            object? planApproval)
        {
            this.FileSearch = fileSearch;
            this.WebSearch = webSearch;
            this.PlanApproval = planApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolResource" /> class.
        /// </summary>
        public AssistantToolResource()
        {
        }
    }
}