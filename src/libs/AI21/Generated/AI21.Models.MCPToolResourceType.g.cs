
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: mcp
    /// </summary>
    public enum MCPToolResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolResourceType value)
        {
            return value switch
            {
                MCPToolResourceType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolResourceType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => MCPToolResourceType.Mcp,
                _ => null,
            };
        }
    }
}