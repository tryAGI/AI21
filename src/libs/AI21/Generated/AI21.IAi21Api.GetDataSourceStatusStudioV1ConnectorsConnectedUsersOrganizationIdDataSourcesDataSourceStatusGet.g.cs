#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Data Source Status
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="dataSource"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900642
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConnectorsStatus> GetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetAsync(
            string organizationId,
            string dataSource,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}