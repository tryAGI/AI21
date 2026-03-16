#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Create Mcp Storage
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MCPStorageResponse> CreateMcpStorageStudioV1McpStoragePostAsync(

            global::AI21.CreateMCPStorageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Mcp Storage
        /// </summary>
        /// <param name="serverUrl"></param>
        /// <param name="serverLabel"></param>
        /// <param name="workspaceId"></param>
        /// <param name="authenticationType">
        /// An enumeration.
        /// </param>
        /// <param name="authHeaderName"></param>
        /// <param name="authValue"></param>
        /// <param name="allowedTools"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MCPStorageResponse> CreateMcpStorageStudioV1McpStoragePostAsync(
            string serverUrl,
            string serverLabel,
            global::System.Guid? workspaceId = default,
            global::AI21.AuthenticationType? authenticationType = default,
            string? authHeaderName = default,
            string? authValue = default,
            global::System.Collections.Generic.IList<string>? allowedTools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}