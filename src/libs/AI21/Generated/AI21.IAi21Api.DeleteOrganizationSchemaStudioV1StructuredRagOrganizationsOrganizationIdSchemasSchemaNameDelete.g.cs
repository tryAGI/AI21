#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Delete Organization Schema
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="schemaName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationSchemaStudioV1StructuredRagOrganizationsOrganizationIdSchemasSchemaNameDeleteAsync(
            string organizationId,
            string schemaName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}