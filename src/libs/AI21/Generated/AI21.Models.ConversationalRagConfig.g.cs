
#nullable enable

namespace AI21
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class ConversationalRagConfig
    {
        /// <summary>
        /// messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.Message> Messages { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segments")]
        public int? MaxSegments { get; set; }

        /// <summary>
        /// Default Value: segments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.ConversationalRagConfigRetrievalStrategyJsonConverter))]
        public global::AI21.ConversationalRagConfigRetrievalStrategy? RetrievalStrategy { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_similarity_threshold")]
        public double? RetrievalSimilarityThreshold { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_neighbors")]
        public int? MaxNeighbors { get; set; }

        /// <summary>
        /// Default Value: 0.98
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hybrid_search_alpha")]
        public double? HybridSearchAlpha { get; set; }

        /// <summary>
        /// Default Value: english
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.ConversationalRagConfigResponseLanguageJsonConverter))]
        public global::AI21.ConversationalRagConfigResponseLanguage? ResponseLanguage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalRagConfig" /> class.
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="fileIds"></param>
        /// <param name="maxSegments">
        /// Default Value: 15
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: segments
        /// </param>
        /// <param name="retrievalSimilarityThreshold">
        /// Default Value: 0
        /// </param>
        /// <param name="maxNeighbors">
        /// Default Value: 1
        /// </param>
        /// <param name="hybridSearchAlpha">
        /// Default Value: 0.98
        /// </param>
        /// <param name="responseLanguage">
        /// Default Value: english
        /// </param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationalRagConfig(
            global::System.Collections.Generic.IList<global::AI21.Message> messages,
            string? path,
            global::System.Collections.Generic.IList<string>? labels,
            global::System.Collections.Generic.IList<string>? fileIds,
            int? maxSegments,
            global::AI21.ConversationalRagConfigRetrievalStrategy? retrievalStrategy,
            double? retrievalSimilarityThreshold,
            int? maxNeighbors,
            double? hybridSearchAlpha,
            global::AI21.ConversationalRagConfigResponseLanguage? responseLanguage,
            bool? verbose)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Path = path;
            this.Labels = labels;
            this.FileIds = fileIds;
            this.MaxSegments = maxSegments;
            this.RetrievalStrategy = retrievalStrategy;
            this.RetrievalSimilarityThreshold = retrievalSimilarityThreshold;
            this.MaxNeighbors = maxNeighbors;
            this.HybridSearchAlpha = hybridSearchAlpha;
            this.ResponseLanguage = responseLanguage;
            this.Verbose = verbose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalRagConfig" /> class.
        /// </summary>
        public ConversationalRagConfig()
        {
        }
    }
}