#nullable enable

namespace AI21
{
    public partial interface IWebsiteConnectorClient
    {
        /// <summary>
        /// Get Website Status
        /// </summary>
        /// <param name="websiteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorGetWebsiteStatusAsync(
            global::System.Guid websiteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}