#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Execute Conv Rag
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteConvRagStudioV1DemosScraperConversationalRagPostAsync(
            global::AI21.ConvRagExecuteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute Conv Rag
        /// </summary>
        /// <param name="message"></param>
        /// <param name="label"></param>
        /// <param name="apiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteConvRagStudioV1DemosScraperConversationalRagPostAsync(
            string message,
            string? label = default,
            string? apiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}