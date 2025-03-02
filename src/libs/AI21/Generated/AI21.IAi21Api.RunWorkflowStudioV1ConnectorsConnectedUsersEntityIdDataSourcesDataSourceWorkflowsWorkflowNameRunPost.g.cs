#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Run Workflow
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="dataSource"></param>
        /// <param name="workflowName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RunWorkflowStudioV1ConnectorsConnectedUsersEntityIdDataSourcesDataSourceWorkflowsWorkflowNameRunPostAsync(
            string entityId,
            string dataSource,
            string workflowName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}