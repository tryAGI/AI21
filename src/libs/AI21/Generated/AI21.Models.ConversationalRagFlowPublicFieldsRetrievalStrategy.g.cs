
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: default
    /// </summary>
    public enum ConversationalRagFlowPublicFieldsRetrievalStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Segments,
        /// <summary>
        /// 
        /// </summary>
        AddNeighbors,
        /// <summary>
        /// 
        /// </summary>
        FullDoc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationalRagFlowPublicFieldsRetrievalStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationalRagFlowPublicFieldsRetrievalStrategy value)
        {
            return value switch
            {
                ConversationalRagFlowPublicFieldsRetrievalStrategy.Default => "default",
                ConversationalRagFlowPublicFieldsRetrievalStrategy.Segments => "segments",
                ConversationalRagFlowPublicFieldsRetrievalStrategy.AddNeighbors => "add_neighbors",
                ConversationalRagFlowPublicFieldsRetrievalStrategy.FullDoc => "full_doc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationalRagFlowPublicFieldsRetrievalStrategy? ToEnum(string value)
        {
            return value switch
            {
                "default" => ConversationalRagFlowPublicFieldsRetrievalStrategy.Default,
                "segments" => ConversationalRagFlowPublicFieldsRetrievalStrategy.Segments,
                "add_neighbors" => ConversationalRagFlowPublicFieldsRetrievalStrategy.AddNeighbors,
                "full_doc" => ConversationalRagFlowPublicFieldsRetrievalStrategy.FullDoc,
                _ => null,
            };
        }
    }
}