#nullable enable

namespace AI21
{
    public partial interface IRAGEngineClient
    {
        /// <summary>
        /// Generate Documents Signed Url
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1LibraryManagement2Async(
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}