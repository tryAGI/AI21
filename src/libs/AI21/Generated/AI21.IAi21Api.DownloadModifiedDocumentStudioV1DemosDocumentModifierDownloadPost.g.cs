#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Download Modified Document<br/>
        /// Download a modified document.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DownloadModifiedDocumentStudioV1DemosDocumentModifierDownloadPostAsync(
            global::AI21.DownloadModifiedDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Download Modified Document<br/>
        /// Download a modified document.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DownloadModifiedDocumentStudioV1DemosDocumentModifierDownloadPostAsync(
            string content,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}