#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Submit Insight Feedback<br/>
        /// Record the user's verdict (+ optional comment) on an insight.<br/>
        /// Orthogonal to the lifecycle — allowed in every customer-visible state, and<br/>
        /// last write wins. The gateway owns the closed verdict set.
        /// </summary>
        /// <param name="insightId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.InsightOut> SubmitInsightFeedbackGatewayInsightsInsightIdFeedbackPostAsync(
            string insightId,

            global::AI21.InsightFeedbackIn request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Insight Feedback<br/>
        /// Record the user's verdict (+ optional comment) on an insight.<br/>
        /// Orthogonal to the lifecycle — allowed in every customer-visible state, and<br/>
        /// last write wins. The gateway owns the closed verdict set.
        /// </summary>
        /// <param name="insightId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::AI21.InsightOut>> SubmitInsightFeedbackGatewayInsightsInsightIdFeedbackPostAsResponseAsync(
            string insightId,

            global::AI21.InsightFeedbackIn request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Insight Feedback<br/>
        /// Record the user's verdict (+ optional comment) on an insight.<br/>
        /// Orthogonal to the lifecycle — allowed in every customer-visible state, and<br/>
        /// last write wins. The gateway owns the closed verdict set.
        /// </summary>
        /// <param name="insightId"></param>
        /// <param name="verdict"></param>
        /// <param name="comment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.InsightOut> SubmitInsightFeedbackGatewayInsightsInsightIdFeedbackPostAsync(
            string insightId,
            string verdict,
            string? comment = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}