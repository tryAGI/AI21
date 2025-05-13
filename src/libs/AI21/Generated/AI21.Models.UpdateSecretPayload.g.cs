
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSecretPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        public string? SecretName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        public string? SecretValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSecretPayload" /> class.
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="secretValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSecretPayload(
            string? secretName,
            string? secretValue)
        {
            this.SecretName = secretName;
            this.SecretValue = secretValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSecretPayload" /> class.
        /// </summary>
        public UpdateSecretPayload()
        {
        }
    }
}