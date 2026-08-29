#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// List All Insights<br/>
        /// Every insight for the workspace in one read, newest first, with an optional<br/>
        /// ``agent_id`` filter that rides through on the query string.<br/>
        /// Backs the overview roster's recommendations pill, which needs a count per<br/>
        /// agent and would otherwise fan out one request per row (OPSS-328).<br/>
        /// Unlike :func:`list_insights` this is NOT published-only — it forwards the<br/>
        /// upstream's authoring view verbatim, so ``draft`` / ``dismissed`` / ``applied``<br/>
        /// rows reach the client, which filters to the states it wants to show.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AI21.InsightOut>> ListAllInsightsTokenwiseInsightsAllGetAsync(
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List All Insights<br/>
        /// Every insight for the workspace in one read, newest first, with an optional<br/>
        /// ``agent_id`` filter that rides through on the query string.<br/>
        /// Backs the overview roster's recommendations pill, which needs a count per<br/>
        /// agent and would otherwise fan out one request per row (OPSS-328).<br/>
        /// Unlike :func:`list_insights` this is NOT published-only — it forwards the<br/>
        /// upstream's authoring view verbatim, so ``draft`` / ``dismissed`` / ``applied``<br/>
        /// rows reach the client, which filters to the states it wants to show.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::AI21.InsightOut>>> ListAllInsightsTokenwiseInsightsAllGetAsResponseAsync(
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}