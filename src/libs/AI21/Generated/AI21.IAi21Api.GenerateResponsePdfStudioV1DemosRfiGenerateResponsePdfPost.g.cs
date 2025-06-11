#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Combine section answers ➜ styled PDF for download
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateResponsePdfStudioV1DemosRfiGenerateResponsePdfPostAsync(
            global::AI21.MarkdownRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Combine section answers ➜ styled PDF for download
        /// </summary>
        /// <param name="text">
        /// All section answers concatenated
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateResponsePdfStudioV1DemosRfiGenerateResponsePdfPostAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}