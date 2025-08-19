#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get Organization Schemas
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.OrgSchemas> GetOrganizationSchemasStudioV1StructuredRagOrganizationsOrganizationIdSchemasGetAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}