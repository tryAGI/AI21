#nullable enable

namespace AI21
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Add Dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1UploadDatasetAsync(
            global::AI21.BodyV1UploadDataset request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Dataset
        /// </summary>
        /// <param name="datasetFile"></param>
        /// <param name="datasetFilename"></param>
        /// <param name="datasetName"></param>
        /// <param name="selectedColumns"></param>
        /// <param name="approveWhitespaceCorrection"></param>
        /// <param name="deleteLongRows"></param>
        /// <param name="splitRatio">
        /// Default Value: 0.1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1UploadDatasetAsync(
            byte[] datasetFile,
            string datasetFilename,
            string datasetName,
            string? selectedColumns = default,
            bool? approveWhitespaceCorrection = default,
            bool? deleteLongRows = default,
            double? splitRatio = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}