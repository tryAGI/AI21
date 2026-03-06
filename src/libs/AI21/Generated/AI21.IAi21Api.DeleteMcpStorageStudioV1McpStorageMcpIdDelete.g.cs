#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Delete Mcp Storage
        /// </summary>
        /// <param name="mcpId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.DeleteMCPStorageResponse> DeleteMcpStorageStudioV1McpStorageMcpIdDeleteAsync(
            string mcpId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}