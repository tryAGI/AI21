#nullable enable

namespace AI21
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Get Custom Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1GetCustomModelAsync(
            string customModelPid,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}