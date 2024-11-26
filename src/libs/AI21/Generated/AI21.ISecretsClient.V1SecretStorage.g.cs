#nullable enable

namespace AI21
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Get Secret List
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1SecretStorageAsync(
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}