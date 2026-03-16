#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Get Assistants By Mcp
        /// </summary>
        /// <param name="mcpId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AssistantsByMcpResponse> GetAssistantsByMcpStudioV1McpStorageMcpIdAssistantsGetAsync(
            string mcpId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}