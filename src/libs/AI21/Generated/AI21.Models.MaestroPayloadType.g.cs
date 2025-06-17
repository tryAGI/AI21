
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum MaestroPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationalRag,
        /// <summary>
        /// 
        /// </summary>
        MaestroRun,
        /// <summary>
        /// 
        /// </summary>
        ConvRagMaestroRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MaestroPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MaestroPayloadType value)
        {
            return value switch
            {
                MaestroPayloadType.ConversationalRag => "conversational_rag",
                MaestroPayloadType.MaestroRun => "maestro_run",
                MaestroPayloadType.ConvRagMaestroRun => "conv_rag_maestro_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MaestroPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversational_rag" => MaestroPayloadType.ConversationalRag,
                "maestro_run" => MaestroPayloadType.MaestroRun,
                "conv_rag_maestro_run" => MaestroPayloadType.ConvRagMaestroRun,
                _ => null,
            };
        }
    }
}