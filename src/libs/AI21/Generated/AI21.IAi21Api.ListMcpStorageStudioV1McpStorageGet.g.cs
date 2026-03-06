#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// List Mcp Storage
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ListMCPsStorageResponse> ListMcpStorageStudioV1McpStorageGetAsync(
            global::System.Guid? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}