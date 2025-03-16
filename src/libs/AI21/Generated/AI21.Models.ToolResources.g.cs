
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public object? FileSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public object? WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResources" /> class.
        /// </summary>
        /// <param name="fileSearch"></param>
        /// <param name="webSearch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolResources(
            object? fileSearch,
            object? webSearch)
        {
            this.FileSearch = fileSearch;
            this.WebSearch = webSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResources" /> class.
        /// </summary>
        public ToolResources()
        {
        }
    }
}