
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
        JambaInstruct,
        /// <summary>
        /// 
        /// </summary>
        JambaInstructPreview,
        /// <summary>
        /// 
        /// </summary>
        Jamba15Mini,
        /// <summary>
        /// 
        /// </summary>
        Jamba15Large,
        /// <summary>
        /// 
        /// </summary>
        JambaMini15,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge15,
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
        JambaMini16202503,
        /// <summary>
        /// 
        /// </summary>
        JambaLarge16202503,
        /// <summary>
        /// 
        /// </summary>
        JambaMini16Booking,
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
                ModelName.JambaInstruct => "jamba-instruct",
                ModelName.JambaInstructPreview => "jamba-instruct-preview",
                ModelName.Jamba15Mini => "jamba-1.5-mini",
                ModelName.Jamba15Large => "jamba-1.5-large",
                ModelName.JambaMini15 => "jamba-mini-1.5",
                ModelName.JambaLarge15 => "jamba-large-1.5",
                ModelName.JambaMini => "jamba-mini",
                ModelName.JambaLarge => "jamba-large",
                ModelName.JambaMini16 => "jamba-mini-1.6",
                ModelName.JambaLarge16 => "jamba-large-1.6",
                ModelName.JambaMini16202503 => "jamba-mini-1.6-2025-03",
                ModelName.JambaLarge16202503 => "jamba-large-1.6-2025-03",
                ModelName.JambaMini16Booking => "jamba-mini-1.6-booking",
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
                "jamba-instruct" => ModelName.JambaInstruct,
                "jamba-instruct-preview" => ModelName.JambaInstructPreview,
                "jamba-1.5-mini" => ModelName.Jamba15Mini,
                "jamba-1.5-large" => ModelName.Jamba15Large,
                "jamba-mini-1.5" => ModelName.JambaMini15,
                "jamba-large-1.5" => ModelName.JambaLarge15,
                "jamba-mini" => ModelName.JambaMini,
                "jamba-large" => ModelName.JambaLarge,
                "jamba-mini-1.6" => ModelName.JambaMini16,
                "jamba-large-1.6" => ModelName.JambaLarge16,
                "jamba-mini-1.6-2025-03" => ModelName.JambaMini16202503,
                "jamba-large-1.6-2025-03" => ModelName.JambaLarge16202503,
                "jamba-mini-1.6-booking" => ModelName.JambaMini16Booking,
                _ => null,
            };
        }
    }
}