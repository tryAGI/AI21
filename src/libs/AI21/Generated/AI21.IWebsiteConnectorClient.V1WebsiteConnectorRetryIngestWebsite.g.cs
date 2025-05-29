#nullable enable

namespace AI21
{
    public partial interface IWebsiteConnectorClient
    {
        /// <summary>
        /// Retry Ingest Website
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorRetryIngestWebsiteAsync(
            global::AI21.WebsiteConnectorRetryIngestWebsitePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Retry Ingest Website
        /// </summary>
        /// <param name="websiteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorRetryIngestWebsiteAsync(
            global::System.Guid websiteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}