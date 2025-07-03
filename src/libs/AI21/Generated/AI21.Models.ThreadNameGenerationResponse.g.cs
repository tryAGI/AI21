
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadNameGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadNameGenerationResponse" /> class.
        /// </summary>
        /// <param name="threadName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadNameGenerationResponse(
            string threadName)
        {
            this.ThreadName = threadName ?? throw new global::System.ArgumentNullException(nameof(threadName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadNameGenerationResponse" /> class.
        /// </summary>
        public ThreadNameGenerationResponse()
        {
        }
    }
}