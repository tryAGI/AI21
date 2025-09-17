
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: web_search
    /// </summary>
    public enum WebSearchToolResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolResourceType value)
        {
            return value switch
            {
                WebSearchToolResourceType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolResourceType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => WebSearchToolResourceType.WebSearch,
                _ => null,
            };
        }
    }
}