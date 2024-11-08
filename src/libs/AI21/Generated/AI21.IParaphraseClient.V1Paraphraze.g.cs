#nullable enable

namespace AI21
{
    public partial interface IParaphraseClient
    {
        /// <summary>
        /// Paraphrase
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1ParaphrazeAsync(
            global::AI21.ParaphraseBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Paraphrase
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="text"></param>
        /// <param name="style">
        /// Default Value: general
        /// </param>
        /// <param name="startIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="endIndex"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1ParaphrazeAsync(
            string text,
            int? requestStartTime = default,
            global::AI21.StyleType? style = default,
            int? startIndex = default,
            int? endIndex = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}