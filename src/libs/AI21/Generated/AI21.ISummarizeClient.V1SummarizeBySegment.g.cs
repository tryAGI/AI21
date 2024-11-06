#nullable enable

namespace AI21
{
    public partial interface ISummarizeClient
    {
        /// <summary>
        /// Segmented Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730899065206
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SummarizeBySegmentResponse> V1SummarizeBySegmentAsync(
            global::AI21.SegmentedSummaryBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Segmented Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730899065206
        /// </param>
        /// <param name="source"></param>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="focus"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SummarizeBySegmentResponse> V1SummarizeBySegmentAsync(
            string source,
            global::AI21.DocumentType sourceType,
            int? requestStartTime = default,
            string? focus = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}