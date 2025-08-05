
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ModelName
    {
        /// <summary>
        /// 
        /// </summary>
        JambaMini,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge,
        /// <summary>
        /// 
        /// </summary>
        JambaMini17,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge17,
        /// <summary>
        /// 
        /// </summary>
        JambaMini17202507,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge17202507,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelName value)
        {
            return value switch
            {
                ModelName.JambaMini => "jamba-mini",
                ModelName.JambaLarge => "jamba-large",
                ModelName.JambaMini17 => "jamba-mini-1.7",
                ModelName.JambaLarge17 => "jamba-large-1.7",
                ModelName.JambaMini17202507 => "jamba-mini-1.7-2025-07",
                ModelName.JambaLarge17202507 => "jamba-large-1.7-2025-07",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelName? ToEnum(string value)
        {
            return value switch
            {
                "jamba-mini" => ModelName.JambaMini,
                "jamba-large" => ModelName.JambaLarge,
                "jamba-mini-1.7" => ModelName.JambaMini17,
                "jamba-large-1.7" => ModelName.JambaLarge17,
                "jamba-mini-1.7-2025-07" => ModelName.JambaMini17202507,
                "jamba-large-1.7-2025-07" => ModelName.JambaLarge17202507,
                _ => null,
            };
        }
    }
}