#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Dismiss Insight<br/>
        /// Dismiss an insight (``published`` -&gt; ``dismissed``).
        /// </summary>
        /// <param name="insightId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.InsightOut> DismissInsightGatewayInsightsInsightIdDismissPostAsync(
            string insightId,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dismiss Insight<br/>
        /// Dismiss an insight (``published`` -&gt; ``dismissed``).
        /// </summary>
        /// <param name="insightId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::AI21.InsightOut>> DismissInsightGatewayInsightsInsightIdDismissPostAsResponseAsync(
            string insightId,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}