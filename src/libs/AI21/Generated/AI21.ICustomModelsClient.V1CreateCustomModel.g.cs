#nullable enable

namespace AI21
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Create Custom Model
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900642
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1CreateCustomModelAsync(
            global::AI21.CustomModelInput request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Custom Model
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900642
        /// </param>
        /// <param name="modelType">
        /// An enumeration.
        /// </param>
        /// <param name="learningRate"></param>
        /// <param name="numEpochs"></param>
        /// <param name="datasetId"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1CreateCustomModelAsync(
            global::AI21.CustomModelType modelType,
            string datasetId,
            string modelName,
            int? requestStartTime = default,
            double? learningRate = default,
            int? numEpochs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}