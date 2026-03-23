
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum AssistantType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Maestro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantType value)
        {
            return value switch
            {
                AssistantType.Chat => "chat",
                AssistantType.Default => "default",
                AssistantType.Maestro => "maestro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => AssistantType.Chat,
                "default" => AssistantType.Default,
                "maestro" => AssistantType.Maestro,
                _ => null,
            };
        }
    }
}