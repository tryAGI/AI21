#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Can Iframe
        /// </summary>
        /// <param name="url"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CanIframeStudioV1DemosScraperCanIframeGetAsync(
            string url,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}