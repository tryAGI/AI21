
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceModelUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        public string? SecretId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceModelUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="modelType"></param>
        /// <param name="secretId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceModelUpdate(
            string? name,
            string? modelType,
            string? secretId)
        {
            this.Name = name;
            this.ModelType = modelType;
            this.SecretId = secretId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceModelUpdate" /> class.
        /// </summary>
        public WorkspaceModelUpdate()
        {
        }
    }
}