#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Mcp Tool Discovery
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MCPDiscoveryResponse> McpToolDiscoveryStudioV1McpDiscoverPostAsync(
            global::AI21.MCPDefinition request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Mcp Tool Discovery
        /// </summary>
        /// <param name="serverUrl"></param>
        /// <param name="serverLabel"></param>
        /// <param name="headers"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MCPDiscoveryResponse> McpToolDiscoveryStudioV1McpDiscoverPostAsync(
            string serverUrl,
            string? serverLabel = default,
            object? headers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}