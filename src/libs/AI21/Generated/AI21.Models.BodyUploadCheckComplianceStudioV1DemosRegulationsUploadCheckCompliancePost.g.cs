
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="budget">
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="vectorStoreId">
        /// Vector store ID to use for RFI processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost(
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
        /// Initializes a new instance of the <see cref="BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost" /> class.
        /// </summary>
        public BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost()
        {
        }
    }
}