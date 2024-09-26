#nullable enable

namespace AI21
{
    public partial interface IGrammaticalErrorCorrectionsClient
    {
        /// <summary>
        /// Grammatical Error Corrections
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.CorrectionsResponse> V1CorrectionsAsync(
            global::AI21.CorrectionsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Grammatical Error Corrections
        /// </summary>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.CorrectionsResponse> V1CorrectionsAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}