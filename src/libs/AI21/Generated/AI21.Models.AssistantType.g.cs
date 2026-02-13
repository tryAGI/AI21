
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
        Default,
        /// <summary>
        /// 
        /// </summary>
        Chat,
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
                AssistantType.Default => "default",
                AssistantType.Chat => "chat",
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
                "default" => AssistantType.Default,
                "chat" => AssistantType.Chat,
                "maestro" => AssistantType.Maestro,
                _ => null,
            };
        }
    }
}