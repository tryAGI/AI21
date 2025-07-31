
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebsiteConnectorPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Sitemap,
        /// <summary>
        /// 
        /// </summary>
        Urls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsiteConnectorPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsiteConnectorPayloadType value)
        {
            return value switch
            {
                WebsiteConnectorPayloadType.Sitemap => "sitemap",
                WebsiteConnectorPayloadType.Urls => "urls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsiteConnectorPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "sitemap" => WebsiteConnectorPayloadType.Sitemap,
                "urls" => WebsiteConnectorPayloadType.Urls,
                _ => null,
            };
        }
    }
}