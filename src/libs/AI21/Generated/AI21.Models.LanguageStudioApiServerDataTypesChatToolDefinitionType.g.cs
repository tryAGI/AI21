
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguageStudioApiServerDataTypesChatToolDefinitionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageStudioApiServerDataTypesChatToolDefinitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageStudioApiServerDataTypesChatToolDefinitionType value)
        {
            return value switch
            {
                LanguageStudioApiServerDataTypesChatToolDefinitionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageStudioApiServerDataTypesChatToolDefinitionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => LanguageStudioApiServerDataTypesChatToolDefinitionType.Function,
                _ => null,
            };
        }
    }
}