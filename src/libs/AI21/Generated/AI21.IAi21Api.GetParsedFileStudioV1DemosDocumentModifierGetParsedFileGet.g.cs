#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Parsed File<br/>
        /// Get the parsed file from the document modifier.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetParsedFileStudioV1DemosDocumentModifierGetParsedFileGetAsync(
            string fileName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}