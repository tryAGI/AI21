#nullable enable

namespace AI21
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Delete Model
        /// </summary>
        /// <param name="modelPid"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730899065206
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1DeleteCustomModelAsync(
            string modelPid,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}