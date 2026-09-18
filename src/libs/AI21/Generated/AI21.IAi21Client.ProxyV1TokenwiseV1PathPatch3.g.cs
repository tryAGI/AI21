#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Proxy V1<br/>
        /// Catch-all for the Anthropic-compatible surface (``/v1/messages``, etc.).<br/>
        /// Gated on a Tokenwise subscription (OPSS-55); the A/B ``/on`` and ``/off`` arms are<br/>
        /// intentionally left ungated.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyV1TokenwiseV1PathPatch3Async(
            string path,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy V1<br/>
        /// Catch-all for the Anthropic-compatible surface (``/v1/messages``, etc.).<br/>
        /// Gated on a Tokenwise subscription (OPSS-55); the A/B ``/on`` and ``/off`` arms are<br/>
        /// intentionally left ungated.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<string>> ProxyV1TokenwiseV1PathPatch3AsResponseAsync(
            string path,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}