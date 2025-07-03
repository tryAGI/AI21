#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Generate Thread Name
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ThreadNameGenerationResponse> V1StudioApiGenerationThreadNameAsync(
            global::AI21.ThreadNameGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Thread Name
        /// </summary>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ThreadNameGenerationResponse> V1StudioApiGenerationThreadNameAsync(
            string query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}