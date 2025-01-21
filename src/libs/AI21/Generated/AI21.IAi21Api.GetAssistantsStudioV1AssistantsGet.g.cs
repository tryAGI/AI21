#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Assistants
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ListAssistantsResponse> GetAssistantsStudioV1AssistantsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}