
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum UploadMode
    {
        /// <summary>
        /// 
        /// </summary>
        Immediate,
        /// <summary>
        /// 
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadMode value)
        {
            return value switch
            {
                UploadMode.Immediate => "immediate",
                UploadMode.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadMode? ToEnum(string value)
        {
            return value switch
            {
                "immediate" => UploadMode.Immediate,
                "batch" => UploadMode.Batch,
                _ => null,
            };
        }
    }
}