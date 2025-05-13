#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Update Workspace Model Endpoint
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.WorkspaceModelResponse> UpdateWorkspaceModelEndpointStudioV1SettingsModelsNamePatchAsync(
            string name,
            global::AI21.WorkspaceModelUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Workspace Model Endpoint
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestName"></param>
        /// <param name="modelType"></param>
        /// <param name="secretId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.WorkspaceModelResponse> UpdateWorkspaceModelEndpointStudioV1SettingsModelsNamePatchAsync(
            string name,
            string? requestName = default,
            string? modelType = default,
            string? secretId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}