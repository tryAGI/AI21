#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Analytics Errors Breakdown
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AnalyticsErrorsBreakdownTokenwiseAnalyticsV1ErrorsBreakdownGetAsync(
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Analytics Errors Breakdown
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.AutoSDKHttpResponse<string>> AnalyticsErrorsBreakdownTokenwiseAnalyticsV1ErrorsBreakdownGetAsResponseAsync(
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}