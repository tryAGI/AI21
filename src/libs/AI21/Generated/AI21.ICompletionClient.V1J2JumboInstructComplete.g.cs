#nullable enable

namespace AI21
{
    public partial interface ICompletionClient
    {
        /// <summary>
        /// j2-jumbo-instruct complete
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-jumbo-instruct
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898829897
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1J2JumboInstructCompleteAsync(
            global::AI21.CompletionBody request,
            string? model = default,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// j2-jumbo-instruct complete
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-jumbo-instruct
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898829897
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
        global::System.Threading.Tasks.Task<string> V1J2JumboInstructCompleteAsync(
            string prompt,
            string? model = default,
            int? requestStartTime = default,
            int? numResults = default,
            int? maxTokens = default,
            int? minTokens = default,
            double? temperature = default,
            double? topP = default,
            double? minP = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int? topKReturn = default,
            object? logitBias = default,
            global::AI21.Penalty? frequencyPenalty = default,
            global::AI21.Penalty? presencePenalty = default,
            global::AI21.Penalty? countPenalty = default,
            int? epoch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}