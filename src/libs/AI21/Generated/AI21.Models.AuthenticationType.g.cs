
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum AuthenticationType
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        TokenApi,
        /// <summary>
        /// 
        /// </summary>
        CustomHeader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthenticationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationType value)
        {
            return value switch
            {
                AuthenticationType.None => "none",
                AuthenticationType.TokenApi => "token-api",
                AuthenticationType.CustomHeader => "custom-header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationType? ToEnum(string value)
        {
            return value switch
            {
                "none" => AuthenticationType.None,
                "token-api" => AuthenticationType.TokenApi,
                "custom-header" => AuthenticationType.CustomHeader,
                _ => null,
            };
        }
    }
}