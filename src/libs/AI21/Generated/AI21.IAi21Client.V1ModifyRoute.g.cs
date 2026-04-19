#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Modify Route
        /// </summary>
        /// <param name="routeId"></param>
        /// <param name="assistantId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AssistantRoute> V1ModifyRouteAsync(
            string routeId,
            string assistantId,

            global::AI21.UpdateRoutePayload request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Route
        /// </summary>
        /// <param name="routeId"></param>
        /// <param name="assistantId"></param>
        /// <param name="description"></param>
        /// <param name="examples"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AssistantRoute> V1ModifyRouteAsync(
            string routeId,
            string assistantId,
            string description,
            global::System.Collections.Generic.IList<string>? examples = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}