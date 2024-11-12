
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LibraryAnswerResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("answerInContext")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AnswerInContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::AI21.SourceDocument>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAnswerResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="answerInContext"></param>
        /// <param name="answer"></param>
        /// <param name="sources"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LibraryAnswerResponse(
            string id,
            bool answerInContext,
            string? answer,
            global::System.Collections.Generic.IList<global::AI21.SourceDocument>? sources)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AnswerInContext = answerInContext;
            this.Answer = answer;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAnswerResponse" /> class.
        /// </summary>
        public LibraryAnswerResponse()
        {
        }
    }
}