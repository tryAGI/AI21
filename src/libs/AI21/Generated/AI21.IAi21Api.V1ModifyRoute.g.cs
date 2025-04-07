#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Modify Route
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="routeId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AssistantRoute> V1ModifyRouteAsync(
            string assistantId,
            string routeId,
            global::AI21.UpdateRoutePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modify Route
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="routeId"></param>
        /// <param name="description"></param>
        /// <param name="examples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AssistantRoute> V1ModifyRouteAsync(
            string assistantId,
            string routeId,
            string description,
            global::System.Collections.Generic.IList<string>? examples = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}