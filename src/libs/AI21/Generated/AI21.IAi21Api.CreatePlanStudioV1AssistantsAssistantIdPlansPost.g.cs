#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Create Plan
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Plan> CreatePlanStudioV1AssistantsAssistantIdPlansPostAsync(
            string assistantId,
            global::AI21.CreatePlanPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Plan
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="code"></param>
        /// <param name="schemas"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.Plan> CreatePlanStudioV1AssistantsAssistantIdPlansPostAsync(
            string assistantId,
            string code,
            global::System.Collections.Generic.IList<object>? schemas = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}