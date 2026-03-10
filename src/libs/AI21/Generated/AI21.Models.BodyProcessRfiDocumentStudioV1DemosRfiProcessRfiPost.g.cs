
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost
    {
        /// <summary>
        /// RFI document file (PDF supported)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// RFI document file (PDF supported)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Budget level: LOW, MEDIUM, or HIGH<br/>
        /// Default Value: MEDIUM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        public string? Budget { get; set; }

        /// <summary>
        /// Vector store ID to use for RFI processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_id")]
        public string? VectorStoreId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost" /> class.
        /// </summary>
        /// <param name="file">
        /// RFI document file (PDF supported)
        /// </param>
        /// <param name="filename">
        /// RFI document file (PDF supported)
        /// </param>
        /// <param name="budget">
        /// Budget level: LOW, MEDIUM, or HIGH<br/>
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="vectorStoreId">
        /// Vector store ID to use for RFI processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost(
            byte[] file,
            string filename,
            string? budget,
            string? vectorStoreId)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Budget = budget;
            this.VectorStoreId = vectorStoreId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost" /> class.
        /// </summary>
        public BodyProcessRfiDocumentStudioV1DemosRfiProcessRfiPost()
        {
        }
    }
}