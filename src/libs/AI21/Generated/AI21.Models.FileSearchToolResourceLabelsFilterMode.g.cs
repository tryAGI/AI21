
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: AND
    /// </summary>
    public enum FileSearchToolResourceLabelsFilterMode
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
    public static class FileSearchToolResourceLabelsFilterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchToolResourceLabelsFilterMode value)
        {
            return value switch
            {
                FileSearchToolResourceLabelsFilterMode.AND => "AND",
                FileSearchToolResourceLabelsFilterMode.OR => "OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchToolResourceLabelsFilterMode? ToEnum(string value)
        {
            return value switch
            {
                "AND" => FileSearchToolResourceLabelsFilterMode.AND,
                "OR" => FileSearchToolResourceLabelsFilterMode.OR,
                _ => null,
            };
        }
    }
}