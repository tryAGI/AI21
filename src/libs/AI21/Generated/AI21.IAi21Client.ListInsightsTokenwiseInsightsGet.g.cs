#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// List Insights<br/>
        /// Published insights for ``agent_id``, newest first.<br/>
        /// ``agent_id`` is typed here so a missing/empty value fails with 422 before<br/>
        /// reaching the gateway; it rides through to the upstream via the forwarded<br/>
        /// query string (see ``tokenwise_service._build_gateway_request``).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AI21.InsightOut>> ListInsightsTokenwiseInsightsGetAsync(
            string agentId,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Insights<br/>
        /// Published insights for ``agent_id``, newest first.<br/>
        /// ``agent_id`` is typed here so a missing/empty value fails with 422 before<br/>
        /// reaching the gateway; it rides through to the upstream via the forwarded<br/>
        /// query string (see ``tokenwise_service._build_gateway_request``).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::AI21.InsightOut>>> ListInsightsTokenwiseInsightsGetAsResponseAsync(
            string agentId,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}