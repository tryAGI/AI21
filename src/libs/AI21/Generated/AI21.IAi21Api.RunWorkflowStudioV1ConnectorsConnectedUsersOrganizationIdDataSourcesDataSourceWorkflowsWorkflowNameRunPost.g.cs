#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Run Workflow
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="dataSource"></param>
        /// <param name="workflowName"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RunWorkflowStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceWorkflowsWorkflowNameRunPostAsync(
            string organizationId,
            string dataSource,
            string workflowName,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}