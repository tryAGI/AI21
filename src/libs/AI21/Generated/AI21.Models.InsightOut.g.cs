
#nullable enable

namespace AI21
{
    /// <summary>
    /// Response shape for one insight — ``GET /tokenwise/insights`` and the<br/>
    /// ``apply`` / ``dismiss`` / ``acknowledge`` transitions.<br/>
    /// ``state``, ``source`` and ``kind`` stay plain ``str`` (not enums) so a new<br/>
    /// gateway lifecycle state, source or insight kind doesn't force an api-server<br/>
    /// release — the same stance as :class:`AgentOptimization`. The gateway is the<br/>
    /// source of truth (``ai21_intelligent_gateway_api.insights.schemas.InsightResponse``).<br/>
    /// Feedback is two columns, not three: ``verdict`` is required on submission, so<br/>
    /// a non-null ``feedback_verdict`` is itself the "has feedback" signal, and<br/>
    /// ``updated_at`` covers when it arrived.
    /// </summary>
    public sealed partial class InsightOut
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
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("narrative")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Narrative { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projected_savings")]
        public string? ProjectedSavings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimization_id")]
        public string? OptimizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_suggestion")]
        public object? ConfigSuggestion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_verdict")]
        public string? FeedbackVerdict { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_comment")]
        public string? FeedbackComment { get; set; }

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
        /// Initializes a new instance of the <see cref="InsightOut" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="agentId"></param>
        /// <param name="state"></param>
        /// <param name="source"></param>
        /// <param name="kind"></param>
        /// <param name="title"></param>
        /// <param name="narrative"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="author"></param>
        /// <param name="projectedSavings"></param>
        /// <param name="optimizationId"></param>
        /// <param name="configSuggestion"></param>
        /// <param name="feedbackVerdict"></param>
        /// <param name="feedbackComment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsightOut(
            global::System.Guid id,
            global::System.Guid workspaceId,
            string agentId,
            string state,
            string source,
            string kind,
            string title,
            string narrative,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? author,
            string? projectedSavings,
            string? optimizationId,
            object? configSuggestion,
            string? feedbackVerdict,
            string? feedbackComment)
        {
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Author = author;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Narrative = narrative ?? throw new global::System.ArgumentNullException(nameof(narrative));
            this.ProjectedSavings = projectedSavings;
            this.OptimizationId = optimizationId;
            this.ConfigSuggestion = configSuggestion;
            this.FeedbackVerdict = feedbackVerdict;
            this.FeedbackComment = feedbackComment;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightOut" /> class.
        /// </summary>
        public InsightOut()
        {
        }

    }
}