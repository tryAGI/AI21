#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Proxy Bedrock Invoke Stream<br/>
        /// Bedrock ``InvokeModelWithResponseStream`` (``application/vnd.amazon.eventstream``).
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyBedrockInvokeStreamGatewayModelModelIdInvokeWithResponseStreamPostAsync(
            string modelId,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy Bedrock Invoke Stream<br/>
        /// Bedrock ``InvokeModelWithResponseStream`` (``application/vnd.amazon.eventstream``).
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<string>> ProxyBedrockInvokeStreamGatewayModelModelIdInvokeWithResponseStreamPostAsResponseAsync(
            string modelId,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}