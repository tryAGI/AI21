#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Delete Organization Model Endpoint
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationModelEndpointStudioV1SettingsModelsNameDeleteAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}