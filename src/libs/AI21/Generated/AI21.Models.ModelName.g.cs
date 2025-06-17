
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
        JambaMini16,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge16,
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
        JambaMini16202503,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge16202503,
        /// <summary>
        /// 
        /// </summary>
        JambaMini17202506,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge17202506,
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
                ModelName.JambaMini16 => "jamba-mini-1.6",
                ModelName.JambaLarge16 => "jamba-large-1.6",
                ModelName.JambaMini17 => "jamba-mini-1.7",
                ModelName.JambaLarge17 => "jamba-large-1.7",
                ModelName.JambaMini16202503 => "jamba-mini-1.6-2025-03",
                ModelName.JambaLarge16202503 => "jamba-large-1.6-2025-03",
                ModelName.JambaMini17202506 => "jamba-mini-1.7-2025-06",
                ModelName.JambaLarge17202506 => "jamba-large-1.7-2025-06",
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
                "jamba-mini-1.6" => ModelName.JambaMini16,
                "jamba-large-1.6" => ModelName.JambaLarge16,
                "jamba-mini-1.7" => ModelName.JambaMini17,
                "jamba-large-1.7" => ModelName.JambaLarge17,
                "jamba-mini-1.6-2025-03" => ModelName.JambaMini16202503,
                "jamba-large-1.6-2025-03" => ModelName.JambaLarge16202503,
                "jamba-mini-1.7-2025-06" => ModelName.JambaMini17202506,
                "jamba-large-1.7-2025-06" => ModelName.JambaLarge17202506,
                _ => null,
            };
        }
    }
}