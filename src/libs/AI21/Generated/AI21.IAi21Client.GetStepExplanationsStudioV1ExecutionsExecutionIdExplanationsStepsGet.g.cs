#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Get Step Explanations<br/>
        /// Get step explanations for an execution (cached or generated).<br/>
        /// Set force_regenerate=True to regenerate even if cached.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="forceRegenerate">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetStepExplanationsStudioV1ExecutionsExecutionIdExplanationsStepsGetAsync(
            string executionId,
            bool? forceRegenerate = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}