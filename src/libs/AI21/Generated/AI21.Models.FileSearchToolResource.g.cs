
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileSearchToolResource
    {
        /// <summary>
        /// Default Value: file_search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.FileSearchToolResourceTypeJsonConverter))]
        public global::AI21.FileSearchToolResourceType? Type { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_similarity_threshold")]
        public double? RetrievalSimilarityThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// Default Value: AND
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_filter_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.FileSearchToolResourceLabelsFilterModeJsonConverter))]
        public global::AI21.FileSearchToolResourceLabelsFilterMode? LabelsFilterMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.QueryFilterJsonConverter))]
        public global::AI21.QueryFilter? LabelsFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Default Value: segments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.RetrievalStrategyJsonConverter))]
        public global::AI21.RetrievalStrategy? RetrievalStrategy { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_neighbors")]
        public int? MaxNeighbors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Default Value: unset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.FileSearchToolResourceResponseLanguageJsonConverter))]
        public global::AI21.FileSearchToolResourceResponseLanguage? ResponseLanguage { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hybrid_search_alpha")]
        public double? HybridSearchAlpha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolResource" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: file_search
        /// </param>
        /// <param name="retrievalSimilarityThreshold">
        /// Default Value: 0
        /// </param>
        /// <param name="labels"></param>
        /// <param name="labelsFilterMode">
        /// Default Value: AND
        /// </param>
        /// <param name="labelsFilter"></param>
        /// <param name="fileIds"></param>
        /// <param name="retrievalStrategy">
        /// Default Value: segments
        /// </param>
        /// <param name="maxNeighbors">
        /// Default Value: 1
        /// </param>
        /// <param name="path"></param>
        /// <param name="responseLanguage">
        /// Default Value: unset
        /// </param>
        /// <param name="hybridSearchAlpha">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchToolResource(
            global::AI21.FileSearchToolResourceType? type,
            double? retrievalSimilarityThreshold,
            global::System.Collections.Generic.IList<string>? labels,
            global::AI21.FileSearchToolResourceLabelsFilterMode? labelsFilterMode,
            global::AI21.QueryFilter? labelsFilter,
            global::System.Collections.Generic.IList<string>? fileIds,
            global::AI21.RetrievalStrategy? retrievalStrategy,
            int? maxNeighbors,
            string? path,
            global::AI21.FileSearchToolResourceResponseLanguage? responseLanguage,
            double? hybridSearchAlpha)
        {
            this.Type = type;
            this.RetrievalSimilarityThreshold = retrievalSimilarityThreshold;
            this.Labels = labels;
            this.LabelsFilterMode = labelsFilterMode;
            this.LabelsFilter = labelsFilter;
            this.FileIds = fileIds;
            this.RetrievalStrategy = retrievalStrategy;
            this.MaxNeighbors = maxNeighbors;
            this.Path = path;
            this.ResponseLanguage = responseLanguage;
            this.HybridSearchAlpha = hybridSearchAlpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolResource" /> class.
        /// </summary>
        public FileSearchToolResource()
        {
        }
    }
}