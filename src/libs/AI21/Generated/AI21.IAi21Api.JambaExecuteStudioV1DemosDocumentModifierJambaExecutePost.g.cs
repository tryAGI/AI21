#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Jamba Execute<br/>
        /// Execute a Jamba request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> JambaExecuteStudioV1DemosDocumentModifierJambaExecutePostAsync(
            global::AI21.JambaExecuteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Jamba Execute<br/>
        /// Execute a Jamba request.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="task"></param>
        /// <param name="prompt"></param>
        /// <param name="apiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> JambaExecuteStudioV1DemosDocumentModifierJambaExecutePostAsync(
            string content,
            string task,
            string prompt,
            string? apiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}