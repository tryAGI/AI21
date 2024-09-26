#nullable enable

namespace AI21
{
    public partial interface ISegmentationClient
    {
        /// <summary>
        /// Segmentation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SegmentationResponse> V1SegmentationAsync(
            global::AI21.SegmentationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Segmentation
        /// </summary>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SegmentationResponse> V1SegmentationAsync(
            global::AI21.DocumentType sourceType,
            string source,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}