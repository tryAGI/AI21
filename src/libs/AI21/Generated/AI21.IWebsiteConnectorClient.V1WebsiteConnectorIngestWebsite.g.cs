#nullable enable

namespace AI21
{
    public partial interface IWebsiteConnectorClient
    {
        /// <summary>
        /// Ingest Website
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorIngestWebsiteAsync(
            global::AI21.WebsiteConnectorIngestWebsitePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Ingest Website
        /// </summary>
        /// <param name="sitemapUrl"></param>
        /// <param name="clientConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorIngestWebsiteAsync(
            string sitemapUrl,
            string? clientConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}