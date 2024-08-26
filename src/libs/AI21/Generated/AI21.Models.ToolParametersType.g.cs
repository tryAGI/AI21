
#nullable enable

namespace AI21
{
    /// <summary>
    /// Type of the parameter schema, only `object` is supported<br/>
    /// Default Value: object
    /// </summary>
    public enum ToolParametersType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolParametersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolParametersType value)
        {
            return value switch
            {
                ToolParametersType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolParametersType? ToEnum(string value)
        {
            return value switch
            {
                "object" => ToolParametersType.Object,
                _ => null,
            };
        }
    }
}