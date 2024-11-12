
#nullable enable

namespace AI21
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class SegmentationBody
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.DocumentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.DocumentType SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentationBody" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="source"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SegmentationBody(
            global::AI21.DocumentType sourceType,
            string source)
        {
            this.SourceType = sourceType;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentationBody" /> class.
        /// </summary>
        public SegmentationBody()
        {
        }
    }
}