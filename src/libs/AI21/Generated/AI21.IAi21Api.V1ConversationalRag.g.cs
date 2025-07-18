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
        /// <exception cref="global::AI21.ApiException"></exception>
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
        /// <param name="retrievalStrategy">
        /// Default Value: segments
        /// </param>
        /// <param name="retrievalSimilarityThreshold">
        /// Default Value: 0
        /// </param>
        /// <param name="maxNeighbors">
        /// Default Value: 1
        /// </param>
        /// <param name="hybridSearchAlpha">
        /// Default Value: 1
        /// </param>
        /// <param name="responseLanguage">
        /// Default Value: english
        /// </param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
        /// <param name="shouldSetCustomRetrievalConfigs">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConversationalRagResult> V1ConversationalRagAsync(
            global::System.Collections.Generic.IList<global::AI21.Message> messages,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            global::AI21.ConversationalRagConfigRetrievalStrategy? retrievalStrategy = default,
            double? retrievalSimilarityThreshold = default,
            int? maxNeighbors = default,
            double? hybridSearchAlpha = default,
            global::AI21.ConversationalRagConfigResponseLanguage? responseLanguage = default,
            bool? verbose = default,
            bool? shouldSetCustomRetrievalConfigs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}