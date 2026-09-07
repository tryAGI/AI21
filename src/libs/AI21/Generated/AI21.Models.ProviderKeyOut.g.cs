
#nullable enable

namespace AI21
{
    /// <summary>
    /// Response shape for provider-key GET / POST / PUT.<br/>
    /// Never carries the key itself. ``masked_key`` is the BFF's masked rendering<br/>
    /// from the secret store, and is ``null`` when the store is unreachable — whether<br/>
    /// a workspace has a key configured is the BFF's own fact and stays readable even<br/>
    /// when the store is down.
    /// </summary>
    public sealed partial class ProviderKeyOut
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masked_key")]
        public string? MaskedKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderKeyOut" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="maskedKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderKeyOut(
            string provider,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? maskedKey)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.MaskedKey = maskedKey;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderKeyOut" /> class.
        /// </summary>
        public ProviderKeyOut()
        {
        }

    }
}