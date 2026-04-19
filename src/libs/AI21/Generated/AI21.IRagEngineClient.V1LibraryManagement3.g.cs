#nullable enable

namespace AI21
{
    public partial interface IRagEngineClient
    {
        /// <summary>
        /// Download Parsed Document<br/>
        /// Download parsed document with Content-Disposition header for immediate download.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1LibraryManagement3Async(
            global::System.Guid fileId,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}