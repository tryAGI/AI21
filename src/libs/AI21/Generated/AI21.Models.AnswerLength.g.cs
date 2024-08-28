
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum AnswerLength
    {
        /// <summary>
        /// 
        /// </summary>
        Short,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Long,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerLength value)
        {
            return value switch
            {
                AnswerLength.Short => "short",
                AnswerLength.Medium => "medium",
                AnswerLength.Long => "long",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerLength? ToEnum(string value)
        {
            return value switch
            {
                "short" => AnswerLength.Short,
                "medium" => AnswerLength.Medium,
                "long" => AnswerLength.Long,
                _ => null,
            };
        }
    }
}