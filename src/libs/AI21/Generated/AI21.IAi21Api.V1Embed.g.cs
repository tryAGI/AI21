#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Embed
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1EmbedAsync(
            global::AI21.EmbeddingsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Embed
        /// </summary>
        /// <param name="texts"></param>
        /// <param name="type">
        /// Default Value: segment
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1EmbedAsync(
            global::System.Collections.Generic.IList<string> texts,
            global::AI21.EmbedType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}