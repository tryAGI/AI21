#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Modify Plan
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="planId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Plan> ModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchAsync(
            string assistantId,
            string planId,
            global::AI21.CreatePlanPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modify Plan
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="planId"></param>
        /// <param name="code"></param>
        /// <param name="schemas"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Plan> ModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchAsync(
            string assistantId,
            string planId,
            string code,
            global::System.Collections.Generic.IList<object>? schemas = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}