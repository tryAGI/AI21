#nullable enable

namespace AI21
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset Get
        /// </summary>
        /// <param name="datasetPid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1GetDatasetResponse> V1GetDatasetAsync(
            string datasetPid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}