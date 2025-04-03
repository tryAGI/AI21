
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallDeltaStartType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallDeltaStartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallDeltaStartType value)
        {
            return value switch
            {
                ToolCallDeltaStartType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallDeltaStartType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolCallDeltaStartType.Function,
                _ => null,
            };
        }
    }
}