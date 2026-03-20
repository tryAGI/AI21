#nullable enable

namespace AI21
{
    public partial interface IWebsiteConnectorClient
    {
        /// <summary>
        /// Get Url Status
        /// </summary>
        /// <param name="urlId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorGetUrlStatusAsync(
            string urlId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}