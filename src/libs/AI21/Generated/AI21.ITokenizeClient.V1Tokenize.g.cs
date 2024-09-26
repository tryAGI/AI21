#nullable enable

namespace AI21
{
    public partial interface ITokenizeClient
    {
        /// <summary>
        /// Tokenize
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1TokenizeResponse> V1TokenizeAsync(
            global::AI21.TokenizeBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Tokenize
        /// </summary>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1TokenizeResponse> V1TokenizeAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}