
#nullable enable

namespace AI21
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class LibraryAnswerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSegments")]
        public int? MaxSegments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.QueryFilterJsonConverter))]
        public global::AI21.QueryFilter? LabelsFilter { get; set; }

        /// <summary>
        /// Default Value: AND
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_filter_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.LibraryAnswerRequestLabelsFilterModeJsonConverter))]
        public global::AI21.LibraryAnswerRequestLabelsFilterMode? LabelsFilterMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? FileIds { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answerLength")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.AnswerLengthJsonConverter))]
        public global::AI21.AnswerLength? AnswerLength { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.ModeJsonConverter))]
        public global::AI21.Mode? Mode { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievalStrategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.RetrievalStrategyJsonConverter))]
        public global::AI21.RetrievalStrategy? RetrievalStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievalSimilarityThreshold")]
        public double? RetrievalSimilarityThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hybridSearchAlpha")]
        public double? HybridSearchAlpha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAnswerRequest" /> class.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="labelsFilter"></param>
        /// <param name="labelsFilterMode">
        /// Default Value: AND
        /// </param>
        /// <param name="fileIds"></param>
        /// <param name="answerLength">
        /// An enumeration.
        /// </param>
        /// <param name="mode">
        /// An enumeration.
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LibraryAnswerRequest(
            string question,
            int? maxSegments,
            string? path,
            global::System.Collections.Generic.IList<string>? labels,
            global::AI21.QueryFilter? labelsFilter,
            global::AI21.LibraryAnswerRequestLabelsFilterMode? labelsFilterMode,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds,
            global::AI21.AnswerLength? answerLength,
            global::AI21.Mode? mode,
            global::AI21.RetrievalStrategy? retrievalStrategy,
            double? retrievalSimilarityThreshold,
            double? hybridSearchAlpha)
        {
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.MaxSegments = maxSegments;
            this.Path = path;
            this.Labels = labels;
            this.LabelsFilter = labelsFilter;
            this.LabelsFilterMode = labelsFilterMode;
            this.FileIds = fileIds;
            this.AnswerLength = answerLength;
            this.Mode = mode;
            this.RetrievalStrategy = retrievalStrategy;
            this.RetrievalSimilarityThreshold = retrievalSimilarityThreshold;
            this.HybridSearchAlpha = hybridSearchAlpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAnswerRequest" /> class.
        /// </summary>
        public LibraryAnswerRequest()
        {
        }
    }
}