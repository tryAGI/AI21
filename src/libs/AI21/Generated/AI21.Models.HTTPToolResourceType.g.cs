
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: http
    /// </summary>
    public enum HTTPToolResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HTTPToolResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HTTPToolResourceType value)
        {
            return value switch
            {
                HTTPToolResourceType.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HTTPToolResourceType? ToEnum(string value)
        {
            return value switch
            {
                "http" => HTTPToolResourceType.Http,
                _ => null,
            };
        }
    }
}