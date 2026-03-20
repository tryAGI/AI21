#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {

        /// <summary>
        /// Fnac Aftersales Batch Predict Status
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> FnacAftersalesBatchPredictStatusSolutionsFdAftersalesPartsClassificationBatchBatchIdStatusGetAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}