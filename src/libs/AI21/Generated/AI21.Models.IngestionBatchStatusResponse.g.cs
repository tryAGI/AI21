
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IngestionBatchStatusResponse
    {
        /// <summary>
        /// The UUID of the batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string BatchId { get; set; } = default!;

        /// <summary>
        /// Total number of documents in the batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalDocuments { get; set; } = default!;

        /// <summary>
        /// List of document counts by status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::AI21.IgnestionBatchStatusCount> Statuses { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionBatchStatusResponse" /> class.
        /// </summary>
        /// <param name="batchId">
        /// The UUID of the batch
        /// </param>
        /// <param name="totalDocuments">
        /// Total number of documents in the batch
        /// </param>
        /// <param name="statuses">
        /// List of document counts by status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IngestionBatchStatusResponse(
            string batchId,
            int totalDocuments,
            global::System.Collections.Generic.IList<global::AI21.IgnestionBatchStatusCount> statuses)
        {
            this.BatchId = batchId ?? throw new global::System.ArgumentNullException(nameof(batchId));
            this.TotalDocuments = totalDocuments;
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionBatchStatusResponse" /> class.
        /// </summary>
        public IngestionBatchStatusResponse()
        {
        }
    }
}