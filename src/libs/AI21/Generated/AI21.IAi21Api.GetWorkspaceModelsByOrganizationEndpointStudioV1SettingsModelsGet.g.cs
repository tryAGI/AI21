#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Workspace Models By Organization Endpoint
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.WorkspaceModelsResponse> GetWorkspaceModelsByOrganizationEndpointStudioV1SettingsModelsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}