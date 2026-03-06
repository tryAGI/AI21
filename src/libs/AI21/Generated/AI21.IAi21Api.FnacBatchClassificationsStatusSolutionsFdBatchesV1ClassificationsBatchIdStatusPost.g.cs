#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Fnac Batch Classifications Status
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> FnacBatchClassificationsStatusSolutionsFdBatchesV1ClassificationsBatchIdStatusPostAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}