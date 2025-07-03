#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get File Url
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFileUrlStudioV1DemosScraperFileUrlFileIdGetAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}