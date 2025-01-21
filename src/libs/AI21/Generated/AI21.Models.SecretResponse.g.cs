
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretResponse" /> class.
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="secretKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SecretResponse(
            string secretId,
            string secretKey)
        {
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretResponse" /> class.
        /// </summary>
        public SecretResponse()
        {
        }
    }
}