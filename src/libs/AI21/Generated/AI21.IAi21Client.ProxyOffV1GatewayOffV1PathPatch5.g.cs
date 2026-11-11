#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Proxy Off V1<br/>
        /// A/B off-arm — forces gateway transformers off for this request only.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyOffV1GatewayOffV1PathPatch5Async(
            string path,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy Off V1<br/>
        /// A/B off-arm — forces gateway transformers off for this request only.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<string>> ProxyOffV1GatewayOffV1PathPatch5AsResponseAsync(
            string path,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}