#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {

        /// <summary>
        /// Update Mcp Storage
        /// </summary>
        /// <param name="mcpId"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MCPStorageResponse> UpdateMcpStorageStudioV1McpStorageMcpIdPatchAsync(
            string mcpId,

            global::AI21.UpdateMCPStorageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Mcp Storage
        /// </summary>
        /// <param name="mcpId"></param>
        /// <param name="serverLabel"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.MCPStorageResponse> UpdateMcpStorageStudioV1McpStorageMcpIdPatchAsync(
            string mcpId,
            string serverLabel,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}