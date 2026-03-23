
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
        CustomHeader,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        TokenApi,
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
                AuthenticationType.CustomHeader => "custom-header",
                AuthenticationType.None => "none",
                AuthenticationType.TokenApi => "token-api",
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
                "custom-header" => AuthenticationType.CustomHeader,
                "none" => AuthenticationType.None,
                "token-api" => AuthenticationType.TokenApi,
                _ => null,
            };
        }
    }
}