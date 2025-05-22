#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Parse Pdf<br/>
        /// Parse a PDF file and return its contents.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ParsePdfStudioV1DemosDocumentModifierParsePdfPostAsync(
            global::AI21.BodyParsePdfStudioV1DemosDocumentModifierParsePdfPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Parse Pdf<br/>
        /// Parse a PDF file and return its contents.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ParsePdfStudioV1DemosDocumentModifierParsePdfPostAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}