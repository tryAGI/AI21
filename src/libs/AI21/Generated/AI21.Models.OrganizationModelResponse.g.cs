
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationModelResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        public string? SecretId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationModelResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="modelType"></param>
        /// <param name="secretId"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="provider"></param>
        /// <param name="internal">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationModelResponse(
            string name,
            string modelType,
            string? secretId,
            string? createdBy,
            global::System.DateTime? createdAt,
            string? provider,
            bool? @internal)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ModelType = modelType ?? throw new global::System.ArgumentNullException(nameof(modelType));
            this.SecretId = secretId;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.Provider = provider;
            this.Internal = @internal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationModelResponse" /> class.
        /// </summary>
        public OrganizationModelResponse()
        {
        }
    }
}