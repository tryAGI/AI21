#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Generate Org Token
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConnectorsToken> GenerateOrgTokenStudioV1ConnectorsConnectedUsersEntityIdTokensPostAsync(
            string entityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}