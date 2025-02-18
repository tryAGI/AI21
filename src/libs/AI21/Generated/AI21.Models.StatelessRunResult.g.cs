
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StatelessRunResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AI21.JsonConverters.StatelessRunResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AI21.StatelessRunResultStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatelessRunResult" /> class.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="status"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatelessRunResult(
            global::System.Guid executionId,
            global::AI21.StatelessRunResultStatus status,
            object? result)
        {
            this.ExecutionId = executionId;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatelessRunResult" /> class.
        /// </summary>
        public StatelessRunResult()
        {
        }
    }
}