#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Update Config
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConfigProfileOut> UpdateConfigGatewaySettingsConfigsConfigIdPutAsync(
            string configId,

            global::AI21.ConfigProfileUpdate request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Config
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<global::AI21.ConfigProfileOut>> UpdateConfigGatewaySettingsConfigsConfigIdPutAsResponseAsync(
            string configId,

            global::AI21.ConfigProfileUpdate request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Config
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="overrides"></param>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConfigProfileOut> UpdateConfigGatewaySettingsConfigsConfigIdPutAsync(
            string configId,
            string? name = default,
            string? description = default,
            object? overrides = default,
            bool? enabled = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}