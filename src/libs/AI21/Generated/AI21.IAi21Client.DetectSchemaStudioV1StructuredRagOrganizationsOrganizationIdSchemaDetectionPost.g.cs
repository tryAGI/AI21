#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Detect Schema
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.DetectSchemaResponse> DetectSchemaStudioV1StructuredRagOrganizationsOrganizationIdSchemaDetectionPostAsync(
            string organizationId,

            global::AI21.DetectSchemaRequest request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect Schema
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="documents"></param>
        /// <param name="queries"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.DetectSchemaResponse> DetectSchemaStudioV1StructuredRagOrganizationsOrganizationIdSchemaDetectionPostAsync(
            string organizationId,
            global::System.Collections.Generic.IList<global::AI21.DocumentReference> documents,
            global::System.Collections.Generic.IList<string>? queries = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}