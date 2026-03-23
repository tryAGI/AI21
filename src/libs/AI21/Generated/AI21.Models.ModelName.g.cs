
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
        JambaLarge,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge17,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge17202507,
        /// <summary>
        /// 
        /// </summary>
        JambaMini,
        /// <summary>
        /// 
        /// </summary>
        JambaMini2,
        /// <summary>
        /// 
        /// </summary>
        JambaMini2202601,
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
                ModelName.JambaLarge => "jamba-large",
                ModelName.JambaLarge17 => "jamba-large-1.7",
                ModelName.JambaLarge17202507 => "jamba-large-1.7-2025-07",
                ModelName.JambaMini => "jamba-mini",
                ModelName.JambaMini2 => "jamba-mini-2",
                ModelName.JambaMini2202601 => "jamba-mini-2-2026-01",
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
                "jamba-large" => ModelName.JambaLarge,
                "jamba-large-1.7" => ModelName.JambaLarge17,
                "jamba-large-1.7-2025-07" => ModelName.JambaLarge17202507,
                "jamba-mini" => ModelName.JambaMini,
                "jamba-mini-2" => ModelName.JambaMini2,
                "jamba-mini-2-2026-01" => ModelName.JambaMini2202601,
                _ => null,
            };
        }
    }
}