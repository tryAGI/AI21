#nullable enable

namespace AI21
{
    public partial interface ICompletionClient
    {
        /// <summary>
        /// Custom j2-mid complete
        /// </summary>
        /// <param name="customModelName"></param>
        /// <param name="customModelType">
        /// Default Value: j2-mid
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1J2MidCustomModelCompleteResponse> V1J2MidCustomModelCompleteAsync(
            string customModelName,
            global::AI21.CompletionBody request,
            string? customModelType = "j2-mid",
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Custom j2-mid complete
        /// </summary>
        /// <param name="customModelName"></param>
        /// <param name="customModelType">
        /// Default Value: j2-mid
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 16
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="minP">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences"></param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="countPenalty"></param>
        /// <param name="epoch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1J2MidCustomModelCompleteResponse> V1J2MidCustomModelCompleteAsync(
            string customModelName,
            string prompt,
            string? customModelType = "j2-mid",
            int? numResults = 1,
            int? maxTokens = 16,
            int? minTokens = 0,
            double? temperature = 1,
            double? topP = 1,
            double? minP = 0,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int? topKReturn = 0,
            global::AI21.CompletionBodyLogitBias? logitBias = default,
            global::AI21.Penalty? frequencyPenalty = default,
            global::AI21.Penalty? presencePenalty = default,
            global::AI21.Penalty? countPenalty = default,
            int? epoch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}