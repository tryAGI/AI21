#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1AnswerAsync(
            global::AI21.AnswerBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="context"></param>
        /// <param name="question"></param>
        /// <param name="answerLength">
        /// An enumeration.
        /// </param>
        /// <param name="mode">
        /// An enumeration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1AnswerAsync(
            string context,
            string question,
            global::AI21.AnswerLength? answerLength = default,
            global::AI21.Mode? mode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}