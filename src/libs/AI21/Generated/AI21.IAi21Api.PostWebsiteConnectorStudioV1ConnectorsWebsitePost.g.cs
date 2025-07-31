#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Post Website Connector
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PostWebsiteConnectorStudioV1ConnectorsWebsitePostAsync(
            global::AI21.WebsiteConnectorPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Post Website Connector
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PostWebsiteConnectorStudioV1ConnectorsWebsitePostAsync(
            global::AI21.WebsiteConnectorPayloadType type,
            global::AI21.AnyOf<string, global::System.Collections.Generic.IList<string>> value,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}