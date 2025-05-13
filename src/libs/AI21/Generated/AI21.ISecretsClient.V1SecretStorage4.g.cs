#nullable enable

namespace AI21
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Update Secret
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1SecretStorage4Async(
            string secretId,
            global::AI21.UpdateSecretPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Secret
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="secretName"></param>
        /// <param name="secretValue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1SecretStorage4Async(
            string secretId,
            string? secretName = default,
            string? secretValue = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}