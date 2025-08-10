#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Run Sync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RunSyncStudioV1ConnectorsConnectedUsersDataSourcesSyncsPostAsync(
            global::AI21.ConnectorsSyncParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run Sync
        /// </summary>
        /// <param name="token"></param>
        /// <param name="dataSource"></param>
        /// <param name="organizationId"></param>
        /// <param name="pipeline"></param>
        /// <param name="configuration"></param>
        /// <param name="configurationName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RunSyncStudioV1ConnectorsConnectedUsersDataSourcesSyncsPostAsync(
            string token,
            string dataSource,
            string organizationId,
            string pipeline,
            object? configuration = default,
            string? configurationName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}