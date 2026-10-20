#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Proxy Bedrock Count Tokens<br/>
        /// Bedrock ``CountTokens`` — optional for Claude Code (``/context``), not a generation.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyBedrockCountTokensTokenwiseModelModelIdCountTokensPostAsync(
            string modelId,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy Bedrock Count Tokens<br/>
        /// Bedrock ``CountTokens`` — optional for Claude Code (``/context``), not a generation.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="xAi21Key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<string>> ProxyBedrockCountTokensTokenwiseModelModelIdCountTokensPostAsResponseAsync(
            string modelId,
            string? xAi21Key = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}