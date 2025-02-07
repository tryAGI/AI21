
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAssistantResponse
    {
        /// <summary>
        /// Default Value: assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAssistantResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: assistant
        /// </param>
        /// <param name="deleted">
        /// Default Value: true
        /// </param>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAssistantResponse(
            string id,
            string? @object,
            bool? deleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAssistantResponse" /> class.
        /// </summary>
        public DeleteAssistantResponse()
        {
        }
    }
}