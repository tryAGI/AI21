#nullable enable

namespace AI21
{
    public partial interface IWebsiteConnectorClient
    {
        /// <summary>
        /// Connect Website
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorIngestUrlAsync(
            global::AI21.WebsiteConnectorIngestUrlPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Connect Website
        /// </summary>
        /// <param name="url"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorIngestUrlAsync(
            string url,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}