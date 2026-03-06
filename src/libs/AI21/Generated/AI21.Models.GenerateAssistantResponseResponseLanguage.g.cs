
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: unset
    /// </summary>
    public enum GenerateAssistantResponseResponseLanguage
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
    public static class GenerateAssistantResponseResponseLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAssistantResponseResponseLanguage value)
        {
            return value switch
            {
                GenerateAssistantResponseResponseLanguage.Arabic => "arabic",
                GenerateAssistantResponseResponseLanguage.Dutch => "dutch",
                GenerateAssistantResponseResponseLanguage.English => "english",
                GenerateAssistantResponseResponseLanguage.French => "french",
                GenerateAssistantResponseResponseLanguage.German => "german",
                GenerateAssistantResponseResponseLanguage.Hebrew => "hebrew",
                GenerateAssistantResponseResponseLanguage.Italian => "italian",
                GenerateAssistantResponseResponseLanguage.Portuguese => "portuguese",
                GenerateAssistantResponseResponseLanguage.Spanish => "spanish",
                GenerateAssistantResponseResponseLanguage.Unset => "unset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAssistantResponseResponseLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => GenerateAssistantResponseResponseLanguage.Arabic,
                "dutch" => GenerateAssistantResponseResponseLanguage.Dutch,
                "english" => GenerateAssistantResponseResponseLanguage.English,
                "french" => GenerateAssistantResponseResponseLanguage.French,
                "german" => GenerateAssistantResponseResponseLanguage.German,
                "hebrew" => GenerateAssistantResponseResponseLanguage.Hebrew,
                "italian" => GenerateAssistantResponseResponseLanguage.Italian,
                "portuguese" => GenerateAssistantResponseResponseLanguage.Portuguese,
                "spanish" => GenerateAssistantResponseResponseLanguage.Spanish,
                "unset" => GenerateAssistantResponseResponseLanguage.Unset,
                _ => null,
            };
        }
    }
}