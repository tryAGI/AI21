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
        /// <param name="extractLinkedFiles">
        /// Default Value: false
        /// </param>
        /// <param name="waitForDynamicContent">
        /// Default Value: false
        /// </param>
        /// <param name="skipUrlPatterns"></param>
        /// <param name="targetFileExtensions"></param>
        /// <param name="localization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1WebsiteConnectorCreateConfigAsync(
            string name,
            global::System.Collections.Generic.IList<string> skipUrlPatterns,
            global::System.Collections.Generic.IList<string> targetFileExtensions,
            bool? extractLinkedFiles = default,
            bool? waitForDynamicContent = default,
            string? localization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}