#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Stateless Run
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.StatelessRunResult> GetStatelessRunStudioV1StatelessRunExecutionIdGetAsync(
            string executionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}