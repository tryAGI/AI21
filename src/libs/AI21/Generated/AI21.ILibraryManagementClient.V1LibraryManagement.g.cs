#nullable enable

namespace AI21
{
    public partial interface ILibraryManagementClient
    {
        /// <summary>
        /// Get Organization Files<br/>
        /// Get metadata about a specific file by file ID. The file ID is generated by<br/>
        /// AI21 when you upload the file.
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898970831
        /// </param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="status">
        /// An enumeration.
        /// </param>
        /// <param name="label"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AI21.FileResponse>> V1LibraryManagementAsync(
            int? requestStartTime = default,
            string? name = default,
            string? path = default,
            global::AI21.FileStatus? status = default,
            global::System.Collections.Generic.IList<string>? label = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}