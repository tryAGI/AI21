
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: object
    /// </summary>
    public enum HTTPToolFunctionParametersType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HTTPToolFunctionParametersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HTTPToolFunctionParametersType value)
        {
            return value switch
            {
                HTTPToolFunctionParametersType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HTTPToolFunctionParametersType? ToEnum(string value)
        {
            return value switch
            {
                "object" => HTTPToolFunctionParametersType.Object,
                _ => null,
            };
        }
    }
}