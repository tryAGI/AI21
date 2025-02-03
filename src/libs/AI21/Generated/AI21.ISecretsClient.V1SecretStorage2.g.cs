#nullable enable

namespace AI21
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Save Secret
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1SecretStorage2Async(
            global::AI21.CreateSecretPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save Secret
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="secretValue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1SecretStorage2Async(
            string secretName,
            string secretValue,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}