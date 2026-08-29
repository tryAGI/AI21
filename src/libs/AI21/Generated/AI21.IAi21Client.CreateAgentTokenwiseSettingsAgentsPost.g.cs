#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Create Agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AgentOut> CreateAgentTokenwiseSettingsAgentsPostAsync(

            global::AI21.AgentCreate request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::AI21.AgentOut>> CreateAgentTokenwiseSettingsAgentsPostAsResponseAsync(

            global::AI21.AgentCreate request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="kind">
        /// Default Value: other
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="configId"></param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AgentOut> CreateAgentTokenwiseSettingsAgentsPostAsync(
            string agentId,
            string? kind = default,
            string? name = default,
            string? description = default,
            string? configId = default,
            bool? enabled = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}