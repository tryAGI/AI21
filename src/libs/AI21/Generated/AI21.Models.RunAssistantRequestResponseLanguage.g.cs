
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: unset
    /// </summary>
    public enum RunAssistantRequestResponseLanguage
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
    public static class RunAssistantRequestResponseLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunAssistantRequestResponseLanguage value)
        {
            return value switch
            {
                RunAssistantRequestResponseLanguage.Arabic => "arabic",
                RunAssistantRequestResponseLanguage.Dutch => "dutch",
                RunAssistantRequestResponseLanguage.English => "english",
                RunAssistantRequestResponseLanguage.French => "french",
                RunAssistantRequestResponseLanguage.German => "german",
                RunAssistantRequestResponseLanguage.Hebrew => "hebrew",
                RunAssistantRequestResponseLanguage.Italian => "italian",
                RunAssistantRequestResponseLanguage.Portuguese => "portuguese",
                RunAssistantRequestResponseLanguage.Spanish => "spanish",
                RunAssistantRequestResponseLanguage.Unset => "unset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunAssistantRequestResponseLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => RunAssistantRequestResponseLanguage.Arabic,
                "dutch" => RunAssistantRequestResponseLanguage.Dutch,
                "english" => RunAssistantRequestResponseLanguage.English,
                "french" => RunAssistantRequestResponseLanguage.French,
                "german" => RunAssistantRequestResponseLanguage.German,
                "hebrew" => RunAssistantRequestResponseLanguage.Hebrew,
                "italian" => RunAssistantRequestResponseLanguage.Italian,
                "portuguese" => RunAssistantRequestResponseLanguage.Portuguese,
                "spanish" => RunAssistantRequestResponseLanguage.Spanish,
                "unset" => RunAssistantRequestResponseLanguage.Unset,
                _ => null,
            };
        }
    }
}