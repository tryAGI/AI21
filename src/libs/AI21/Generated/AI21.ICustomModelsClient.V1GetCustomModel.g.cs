#nullable enable

namespace AI21
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Get Custom Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1GetCustomModelResponse> V1GetCustomModelAsync(
            string customModelPid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}