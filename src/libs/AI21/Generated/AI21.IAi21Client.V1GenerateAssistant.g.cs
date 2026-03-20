#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Generate Assistant
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.GenerateAssistantResponse> V1GenerateAssistantAsync(

            global::AI21.GenerateAssistantRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Assistant
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="avatar"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.GenerateAssistantResponse> V1GenerateAssistantAsync(
            string prompt,
            string? avatar = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}