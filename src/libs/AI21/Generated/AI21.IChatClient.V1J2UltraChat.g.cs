#nullable enable

namespace AI21
{
    public partial interface IChatClient
    {
        /// <summary>
        /// j2-ultra chat
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898829897
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ChatResponse> V1J2UltraChatAsync(
            global::AI21.LanguageStudioApiServerDataTypesJ2ChatChatRequest request,
            string? model = default,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// j2-ultra chat
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898829897
        /// </param>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="system"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="countPenalty"></param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0.7
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 300
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ChatResponse> V1J2UltraChatAsync(
            global::System.Collections.Generic.IList<global::AI21.ChatMessage> messages,
            string system,
            string? model = default,
            int? requestStartTime = default,
            global::AI21.Penalty? frequencyPenalty = default,
            global::AI21.Penalty? presencePenalty = default,
            global::AI21.Penalty? countPenalty = default,
            int? numResults = default,
            double? temperature = default,
            int? maxTokens = default,
            int? minTokens = default,
            double? topP = default,
            int? topKReturn = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}