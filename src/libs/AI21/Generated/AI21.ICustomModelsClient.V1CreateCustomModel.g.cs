#nullable enable

namespace AI21
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Create Custom Model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1CreateCustomModelResponse> V1CreateCustomModelAsync(
            global::AI21.CustomModelInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Custom Model
        /// </summary>
        /// <param name="modelType">
        /// An enumeration.
        /// </param>
        /// <param name="learningRate"></param>
        /// <param name="numEpochs"></param>
        /// <param name="datasetId"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AI21.V1CreateCustomModelResponse> V1CreateCustomModelAsync(
            global::AI21.CustomModelType modelType,
            string datasetId,
            string modelName,
            double? learningRate = default,
            int? numEpochs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}