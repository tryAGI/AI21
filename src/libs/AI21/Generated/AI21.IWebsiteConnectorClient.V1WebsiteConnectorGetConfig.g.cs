#nullable enable

namespace AI21
{
    public partial interface IWebsiteConnectorClient
    {
        /// <summary>
        /// Get Client Config
        /// </summary>
        /// <param name="configName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorGetConfigAsync(
            string configName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}