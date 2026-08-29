#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Acknowledge Insight<br/>
        /// Mark an advisory insight as acted on (``published`` -&gt; ``acknowledged``).<br/>
        /// The positive terminal action for a ``kind="advisory"`` insight, which carries<br/>
        /// no config suggestion to apply. The gateway 409s a ``config_change`` insight<br/>
        /// here — those go through ``apply``.
        /// </summary>
        /// <param name="insightId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.InsightOut> AcknowledgeInsightGatewayInsightsInsightIdAcknowledgePostAsync(
            string insightId,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Acknowledge Insight<br/>
        /// Mark an advisory insight as acted on (``published`` -&gt; ``acknowledged``).<br/>
        /// The positive terminal action for a ``kind="advisory"`` insight, which carries<br/>
        /// no config suggestion to apply. The gateway 409s a ``config_change`` insight<br/>
        /// here — those go through ``apply``.
        /// </summary>
        /// <param name="insightId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::AI21.InsightOut>> AcknowledgeInsightGatewayInsightsInsightIdAcknowledgePostAsResponseAsync(
            string insightId,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}