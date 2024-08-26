
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MockResponseConfig
    {
        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public double ResponseDelaySeconds { get; set; } = 1;

        /// <summary>
        /// Default Value: 0.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response_delay_between_deltas_seconds")]
        public double StreamResponseDelayBetweenDeltasSeconds { get; set; } = 0.1;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}