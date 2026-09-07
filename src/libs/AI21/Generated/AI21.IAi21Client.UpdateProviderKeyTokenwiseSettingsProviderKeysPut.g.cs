#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Update Provider Key<br/>
        /// Rotate the workspace's key for a provider. 404 if none is configured.<br/>
        /// Full replacement, not a partial update — unlike the agent/config mirrors there<br/>
        /// is no ``exclude_unset``, because ``api_key`` is the whole point of the call.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ProviderKeyOut> UpdateProviderKeyTokenwiseSettingsProviderKeysPutAsync(

            global::AI21.ProviderKeyUpdate request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Provider Key<br/>
        /// Rotate the workspace's key for a provider. 404 if none is configured.<br/>
        /// Full replacement, not a partial update — unlike the agent/config mirrors there<br/>
        /// is no ``exclude_unset``, because ``api_key`` is the whole point of the call.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::AI21.ProviderKeyOut>> UpdateProviderKeyTokenwiseSettingsProviderKeysPutAsResponseAsync(

            global::AI21.ProviderKeyUpdate request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Provider Key<br/>
        /// Rotate the workspace's key for a provider. 404 if none is configured.<br/>
        /// Full replacement, not a partial update — unlike the agent/config mirrors there<br/>
        /// is no ``exclude_unset``, because ``api_key`` is the whole point of the call.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey">
        /// Included only in requests
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ProviderKeyOut> UpdateProviderKeyTokenwiseSettingsProviderKeysPutAsync(
            string provider,
            string? apiKey = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}