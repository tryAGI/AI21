#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Routes
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ListRoutesResponse> V1ListRoutesAsync(
            string assistantId,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}