#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Sync Website
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SyncWebsiteStudioV1ConnectorsWebsiteConnectorIdSyncPostAsync(
            string connectorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}