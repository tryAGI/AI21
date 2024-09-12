
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: AND
    /// </summary>
    public enum LibrarySearchRequestLabelsFilterMode
    {
        /// <summary>
        /// 
        /// </summary>
        AND,
        /// <summary>
        /// 
        /// </summary>
        OR,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LibrarySearchRequestLabelsFilterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LibrarySearchRequestLabelsFilterMode value)
        {
            return value switch
            {
                LibrarySearchRequestLabelsFilterMode.AND => "AND",
                LibrarySearchRequestLabelsFilterMode.OR => "OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LibrarySearchRequestLabelsFilterMode? ToEnum(string value)
        {
            return value switch
            {
                "AND" => LibrarySearchRequestLabelsFilterMode.AND,
                "OR" => LibrarySearchRequestLabelsFilterMode.OR,
                _ => null,
            };
        }
    }
}