
#nullable enable

namespace AI21
{
    /// <summary>
    /// Access our powerful language models using an API that makes you smile<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAi21Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public JambaCompleteClient JambaComplete { get; }

        /// <summary>
        /// 
        /// </summary>
        public CompletionClient Completion { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomModelsClient CustomModels { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public ParaphraseClient Paraphrase { get; }

        /// <summary>
        /// 
        /// </summary>
        public SummarizeClient Summarize { get; }

        /// <summary>
        /// 
        /// </summary>
        public SegmentationClient Segmentation { get; }

        /// <summary>
        /// 
        /// </summary>
        public GrammaticalErrorCorrectionsClient GrammaticalErrorCorrections { get; }

        /// <summary>
        /// 
        /// </summary>
        public LibraryManagementClient LibraryManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public RAGEngineClient RAGEngine { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// 
        /// </summary>
        public TokenizeClient Tokenize { get; }

    }
}