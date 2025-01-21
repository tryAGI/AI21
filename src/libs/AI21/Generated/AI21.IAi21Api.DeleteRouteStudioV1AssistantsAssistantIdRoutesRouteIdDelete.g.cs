#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Delete Route
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="routeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRouteStudioV1AssistantsAssistantIdRoutesRouteIdDeleteAsync(
            string assistantId,
            string routeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}