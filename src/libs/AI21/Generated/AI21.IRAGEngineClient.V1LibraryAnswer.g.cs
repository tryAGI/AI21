#nullable enable

namespace AI21
{
    public partial interface IRAGEngineClient
    {
        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.LibraryAnswerResponse> V1LibraryAnswerAsync(
            global::AI21.LibraryAnswerRequest request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="question"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="labelsFilter"></param>
        /// <param name="labelsFilterMode">
        /// Default Value: AND
        /// </param>
        /// <param name="fileIds"></param>
        /// <param name="answerLength">
        /// An enumeration.
        /// </param>
        /// <param name="mode">
        /// An enumeration.
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.LibraryAnswerResponse> V1LibraryAnswerAsync(
            string question,
            int? requestStartTime = default,
            int? maxSegments = default,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::AI21.QueryFilter? labelsFilter = default,
            global::AI21.LibraryAnswerRequestLabelsFilterMode? labelsFilterMode = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            global::AI21.AnswerLength? answerLength = default,
            global::AI21.Mode? mode = default,
            global::AI21.RetrievalStrategy? retrievalStrategy = default,
            double? retrievalSimilarityThreshold = default,
            double? hybridSearchAlpha = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}