#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Delete Assistant
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.DeleteAssistantResponse> DeleteAssistantStudioV1AssistantsAssistantIdDeleteAsync(
            string assistantId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}