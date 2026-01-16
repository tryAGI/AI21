
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: unset
    /// </summary>
    public enum AssistantResponseLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        Dutch,
        /// <summary>
        /// 
        /// </summary>
        English,
        /// <summary>
        /// 
        /// </summary>
        French,
        /// <summary>
        /// 
        /// </summary>
        German,
        /// <summary>
        /// 
        /// </summary>
        Hebrew,
        /// <summary>
        /// 
        /// </summary>
        Italian,
        /// <summary>
        /// 
        /// </summary>
        Portuguese,
        /// <summary>
        /// 
        /// </summary>
        Spanish,
        /// <summary>
        /// 
        /// </summary>
        Unset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantResponseLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantResponseLanguage value)
        {
            return value switch
            {
                AssistantResponseLanguage.Arabic => "arabic",
                AssistantResponseLanguage.Dutch => "dutch",
                AssistantResponseLanguage.English => "english",
                AssistantResponseLanguage.French => "french",
                AssistantResponseLanguage.German => "german",
                AssistantResponseLanguage.Hebrew => "hebrew",
                AssistantResponseLanguage.Italian => "italian",
                AssistantResponseLanguage.Portuguese => "portuguese",
                AssistantResponseLanguage.Spanish => "spanish",
                AssistantResponseLanguage.Unset => "unset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantResponseLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => AssistantResponseLanguage.Arabic,
                "dutch" => AssistantResponseLanguage.Dutch,
                "english" => AssistantResponseLanguage.English,
                "french" => AssistantResponseLanguage.French,
                "german" => AssistantResponseLanguage.German,
                "hebrew" => AssistantResponseLanguage.Hebrew,
                "italian" => AssistantResponseLanguage.Italian,
                "portuguese" => AssistantResponseLanguage.Portuguese,
                "spanish" => AssistantResponseLanguage.Spanish,
                "unset" => AssistantResponseLanguage.Unset,
                _ => null,
            };
        }
    }
}