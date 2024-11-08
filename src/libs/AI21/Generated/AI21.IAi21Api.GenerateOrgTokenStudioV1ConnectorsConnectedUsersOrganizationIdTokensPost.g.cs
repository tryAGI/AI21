#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Generate Org Token
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConnectorsToken> GenerateOrgTokenStudioV1ConnectorsConnectedUsersOrganizationIdTokensPostAsync(
            string organizationId,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}