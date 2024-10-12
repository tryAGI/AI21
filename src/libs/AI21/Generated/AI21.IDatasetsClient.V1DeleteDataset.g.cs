#nullable enable

namespace AI21
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete Dataset
        /// </summary>
        /// <param name="datasetPid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1DeleteDatasetAsync(
            string datasetPid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}