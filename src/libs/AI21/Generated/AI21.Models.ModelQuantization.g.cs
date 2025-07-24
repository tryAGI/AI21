
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ModelQuantization
    {
        /// <summary>
        /// 
        /// </summary>
        FP8,
        /// <summary>
        /// 
        /// </summary>
        ExpertsInt8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelQuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelQuantization value)
        {
            return value switch
            {
                ModelQuantization.FP8 => "FP8",
                ModelQuantization.ExpertsInt8 => "experts_int8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelQuantization? ToEnum(string value)
        {
            return value switch
            {
                "FP8" => ModelQuantization.FP8,
                "experts_int8" => ModelQuantization.ExpertsInt8,
                _ => null,
            };
        }
    }
}