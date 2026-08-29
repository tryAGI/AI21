
#nullable enable

namespace AI21
{
    /// <summary>
    /// Body for ``POST /tokenwise/insights/{insight_id}/feedback``.<br/>
    /// ``verdict`` stays a plain ``str`` for the same reason as<br/>
    /// :attr:`InsightOut.state` — the gateway owns the closed set (``helpful`` /<br/>
    /// ``not_helpful``) and answers 422 on anything else, so widening it there<br/>
    /// doesn't force an api-server release.<br/>
    /// ``comment`` is bounded at 1000 chars to mirror the gateway's own limit (and<br/>
    /// its ``varchar(1000)`` column) so an over-long body fails here instead of<br/>
    /// making the round trip just to come back 422. The gateway stays the<br/>
    /// authoritative enforcement point; keep this number in sync with it.
    /// </summary>
    public sealed partial class InsightFeedbackIn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Verdict { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightFeedbackIn" /> class.
        /// </summary>
        /// <param name="verdict"></param>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsightFeedbackIn(
            string verdict,
            string? comment)
        {
            this.Verdict = verdict ?? throw new global::System.ArgumentNullException(nameof(verdict));
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightFeedbackIn" /> class.
        /// </summary>
        public InsightFeedbackIn()
        {
        }

    }
}