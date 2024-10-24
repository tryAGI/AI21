#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Conversational Rag
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConversationalRagResult> V1ConversationalRagAsync(
            global::AI21.ConversationalRagConfig request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Conversational Rag
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="fileIds"></param>
        /// <param name="maxSegments">
        /// Default Value: 15
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="retrievalSimilarityThreshold">
        /// Default Value: 0.8
        /// </param>
        /// <param name="maxNeighbors"></param>
        /// <param name="hybridSearchAlpha">
        /// Default Value: 0.98
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConversationalRagResult> V1ConversationalRagAsync(
            global::System.Collections.Generic.IList<global::AI21.Message> messages,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            int? maxSegments = default,
            global::AI21.ConversationalRagConfigRetrievalStrategy? retrievalStrategy = default,
            double? retrievalSimilarityThreshold = default,
            int? maxNeighbors = default,
            double? hybridSearchAlpha = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}