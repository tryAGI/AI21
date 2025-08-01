
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationalRagResult
    {
        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.Message> Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_queries")]
        public global::System.Collections.Generic.IList<string>? SearchQueries { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_retrieved")]
        public bool? ContextRetrieved { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_in_context")]
        public bool? AnswerInContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AI21.ConversationalRagSource> Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalRagResult" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="choices"></param>
        /// <param name="searchQueries"></param>
        /// <param name="contextRetrieved">
        /// Default Value: false
        /// </param>
        /// <param name="answerInContext">
        /// Default Value: false
        /// </param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationalRagResult(
            string id,
            global::System.Collections.Generic.IList<global::AI21.Message> choices,
            global::System.Collections.Generic.IList<global::AI21.ConversationalRagSource> sources,
            global::System.Collections.Generic.IList<string>? searchQueries,
            bool? contextRetrieved,
            bool? answerInContext)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.SearchQueries = searchQueries;
            this.ContextRetrieved = contextRetrieved;
            this.AnswerInContext = answerInContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalRagResult" /> class.
        /// </summary>
        public ConversationalRagResult()
        {
        }
    }
}