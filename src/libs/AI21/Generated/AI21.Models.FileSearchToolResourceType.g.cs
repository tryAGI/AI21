
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: file_search
    /// </summary>
    public enum FileSearchToolResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchToolResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchToolResourceType value)
        {
            return value switch
            {
                FileSearchToolResourceType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchToolResourceType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => FileSearchToolResourceType.FileSearch,
                _ => null,
            };
        }
    }
}