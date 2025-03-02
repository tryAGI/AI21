#nullable enable

namespace AI21
{
    public partial interface ILibraryManagementClient
    {
        /// <summary>
        /// Upload Workspace File<br/>
        /// Upload files to use for [RAG Engine document searches](https://docs.ai21.com/docs/rag-engine-overview).<br/>
        /// You can assign metadata to your files to limit searches to specific files by file metadata.<br/>
        /// There is no bulk upload method; files must be loaded one at a time.<br/>
        /// - **Max number of files:** No limit. The playground limits bulk uploads to 50 files per request.<br/>
        /// - **Max library size:** 1 GB total size. No limit to individual file size.<br/>
        /// - **Supported file types:** PDF, DocX, HTML, TXT
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1LibraryUploadAsync(
            global::AI21.BodyV1LibraryUpload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Workspace File<br/>
        /// Upload files to use for [RAG Engine document searches](https://docs.ai21.com/docs/rag-engine-overview).<br/>
        /// You can assign metadata to your files to limit searches to specific files by file metadata.<br/>
        /// There is no bulk upload method; files must be loaded one at a time.<br/>
        /// - **Max number of files:** No limit. The playground limits bulk uploads to 50 files per request.<br/>
        /// - **Max library size:** 1 GB total size. No limit to individual file size.<br/>
        /// - **Supported file types:** PDF, DocX, HTML, TXT
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="publicUrl"></param>
        /// <param name="customConfigs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1LibraryUploadAsync(
            byte[] file,
            string filename,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            string? publicUrl = default,
            string? customConfigs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}