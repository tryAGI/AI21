#nullable enable

namespace AI21
{
    public partial interface ILibraryManagementClient
    {
        /// <summary>
        /// Delete File<br/>
        /// Delete the specified file from the library.<br/>
        /// **Restrictions**:<br/>
        /// Files in `PROCESSING` status cannot be deleted. Attempts to delete such files will result in a &lt;span style="color:red"&gt;422&lt;/span&gt; error.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1LibraryDeleteAsync(
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}