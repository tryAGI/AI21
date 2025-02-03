
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretPayload" /> class.
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="secretValue"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateSecretPayload(
            string secretName,
            string secretValue)
        {
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.SecretValue = secretValue ?? throw new global::System.ArgumentNullException(nameof(secretValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretPayload" /> class.
        /// </summary>
        public CreateSecretPayload()
        {
        }
    }
}