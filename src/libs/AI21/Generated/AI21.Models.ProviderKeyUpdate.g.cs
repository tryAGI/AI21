
#nullable enable

namespace AI21
{
    /// <summary>
    /// Body for ``PUT /tokenwise/settings/provider-keys`` — rotation.<br/>
    /// Same shape as create; the BFF distinguishes them by method, not by body.
    /// </summary>
    public sealed partial class ProviderKeyUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderKeyUpdate" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderKeyUpdate(
            string provider,
            string? apiKey)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderKeyUpdate" /> class.
        /// </summary>
        public ProviderKeyUpdate()
        {
        }

    }
}