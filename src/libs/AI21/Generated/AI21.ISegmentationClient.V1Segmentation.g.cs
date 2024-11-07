#nullable enable

namespace AI21
{
    public partial interface ISegmentationClient
    {
        /// <summary>
        /// Segmentation
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898829897
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SegmentationResponse> V1SegmentationAsync(
            global::AI21.SegmentationBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Segmentation
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898829897
        /// </param>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SegmentationResponse> V1SegmentationAsync(
            global::AI21.DocumentType sourceType,
            string source,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}