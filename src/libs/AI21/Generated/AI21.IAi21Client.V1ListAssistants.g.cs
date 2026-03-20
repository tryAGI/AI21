#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Get Assistants
        /// </summary>
        /// <param name="workspaceIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ListAssistantsResponse> V1ListAssistantsAsync(
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}