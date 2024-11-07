#nullable enable

namespace AI21
{
    public partial interface ISummarizeClient
    {
        /// <summary>
        /// Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900642
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SummarizationResponse> V1SummarizeAsync(
            global::AI21.SummarizeBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900642
        /// </param>
        /// <param name="source"></param>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="focus"></param>
        /// <param name="summaryMethod">
        /// An enumeration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.SummarizationResponse> V1SummarizeAsync(
            string source,
            global::AI21.DocumentType sourceType,
            int? requestStartTime = default,
            string? focus = default,
            global::AI21.SummaryMethod? summaryMethod = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}