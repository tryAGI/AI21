#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Create Route
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AssistantRoute> V1CreateRouteAsync(
            string assistantId,
            global::AI21.CreateRoutePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Route
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="planId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="examples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AssistantRoute> V1CreateRouteAsync(
            string assistantId,
            string planId,
            string name,
            string description,
            global::System.Collections.Generic.IList<string> examples,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}