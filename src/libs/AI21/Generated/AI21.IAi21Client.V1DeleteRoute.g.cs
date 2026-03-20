#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Delete Route
        /// </summary>
        /// <param name="routeId"></param>
        /// <param name="assistantId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1DeleteRouteAsync(
            string routeId,
            string assistantId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}