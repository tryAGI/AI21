#nullable enable

namespace AI21
{
    public partial interface IAi21Api
    {
        /// <summary>
        /// Get User Data Sources Info
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.ConnectorsDataSources> GetUserDataSourcesInfoStudioV1ConnectorsConnectedUsersUserIdDataSourcesGetAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}