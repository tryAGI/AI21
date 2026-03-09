
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IgnestionBatchStatusCount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IgnestionBatchStatusCount" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IgnestionBatchStatusCount(
            string status,
            int count)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IgnestionBatchStatusCount" /> class.
        /// </summary>
        public IgnestionBatchStatusCount()
        {
        }
    }
}