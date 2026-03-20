#nullable enable

namespace AI21
{
    public partial interface IRagEngineClient
    {
        /// <summary>
        /// Get Batch Ingestion Status
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.IngestionBatchStatusResponse> V1LibraryManagementAsync(
            global::System.Guid batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}