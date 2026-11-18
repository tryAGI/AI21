#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Proxy Foundry V1<br/>
        /// Anthropic-compatible surface on a listed Microsoft Foundry resource.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="path"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyFoundryV1GatewayFoundryResourceV1PathPatchAsync(
            string resource,
            string path,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy Foundry V1<br/>
        /// Anthropic-compatible surface on a listed Microsoft Foundry resource.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="path"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<string>> ProxyFoundryV1GatewayFoundryResourceV1PathPatchAsResponseAsync(
            string resource,
            string path,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}