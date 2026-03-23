
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum DemoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DemoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DemoVisibility value)
        {
            return value switch
            {
                DemoVisibility.Private => "private",
                DemoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DemoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => DemoVisibility.Private,
                "public" => DemoVisibility.Public,
                _ => null,
            };
        }
    }
}