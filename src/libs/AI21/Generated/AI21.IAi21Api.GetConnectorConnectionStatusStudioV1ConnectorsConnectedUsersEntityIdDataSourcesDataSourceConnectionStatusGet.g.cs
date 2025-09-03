#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Connector Connection Status
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="dataSource"></param>
        /// <param name="paragonToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConnectorConnectionStatus> GetConnectorConnectionStatusStudioV1ConnectorsConnectedUsersEntityIdDataSourcesDataSourceConnectionStatusGetAsync(
            string entityId,
            string dataSource,
            string paragonToken,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}