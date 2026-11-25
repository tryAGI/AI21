#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Proxy On V1<br/>
        /// A/B on-arm — forces gateway transformers on for this request only.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyOnV1GatewayOnV1PathDelete2Async(
            string path,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy On V1<br/>
        /// A/B on-arm — forces gateway transformers on for this request only.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<string>> ProxyOnV1GatewayOnV1PathDelete2AsResponseAsync(
            string path,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}