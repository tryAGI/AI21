#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Plan
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="planId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Plan> GetPlanStudioV1AssistantsAssistantIdPlansPlanIdGetAsync(
            string assistantId,
            string planId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}