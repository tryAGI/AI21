#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Workspace Model Secret Endpoint
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SecretResponse> GetWorkspaceModelSecretEndpointStudioV1SettingsModelsNameSecretsGetAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}