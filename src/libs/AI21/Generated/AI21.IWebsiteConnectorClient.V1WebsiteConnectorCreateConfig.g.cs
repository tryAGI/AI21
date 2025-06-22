#nullable enable

namespace AI21
{
    public partial interface IWebsiteConnectorClient
    {
        /// <summary>
        /// Create Client Config
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorCreateConfigAsync(
            global::AI21.WebsiteConnectorCreateConfigPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Client Config
        /// </summary>
        /// <param name="name"></param>
        /// <param name="getFilesFromSitemap">
        /// Default Value: false
        /// </param>
        /// <param name="isSlowDomain">
        /// Default Value: false
        /// </param>
        /// <param name="urlPatternsToExclude"></param>
        /// <param name="urlExtensionsToKeep"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorCreateConfigAsync(
            string name,
            global::System.Collections.Generic.IList<string> urlPatternsToExclude,
            global::System.Collections.Generic.IList<string> urlExtensionsToKeep,
            bool? getFilesFromSitemap = default,
            bool? isSlowDomain = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}