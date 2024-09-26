#nullable enable

namespace AI21
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset List
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1GetDatasetsResponse> V1GetDatasetsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}