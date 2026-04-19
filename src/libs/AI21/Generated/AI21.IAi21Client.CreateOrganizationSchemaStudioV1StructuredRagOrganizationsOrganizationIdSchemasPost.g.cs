#nullable enable

namespace AI21
{
    public partial interface IAi21Client
    {
        /// <summary>
        /// Create Organization Schema
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateOrganizationSchemaStudioV1StructuredRagOrganizationsOrganizationIdSchemasPostAsync(
            string organizationId,

            global::AI21.CreateOrganizationSchemaRequest request,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Organization Schema
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="schemaName"></param>
        /// <param name="schemaObject"></param>
        /// <param name="runClassification">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateOrganizationSchemaStudioV1StructuredRagOrganizationsOrganizationIdSchemasPostAsync(
            string organizationId,
            string schemaName,
            object schemaObject,
            bool? runClassification = default,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}