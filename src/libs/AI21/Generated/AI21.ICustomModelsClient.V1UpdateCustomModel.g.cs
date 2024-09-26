#nullable enable

namespace AI21
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Update Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1UpdateCustomModelResponse> V1UpdateCustomModelAsync(
            string customModelPid,
            global::AI21.CustomModelUpdateBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="defaultEpoch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1UpdateCustomModelResponse> V1UpdateCustomModelAsync(
            string customModelPid,
            int? defaultEpoch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}