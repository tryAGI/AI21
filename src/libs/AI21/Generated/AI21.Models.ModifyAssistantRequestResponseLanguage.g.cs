
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModifyAssistantRequestResponseLanguage
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
    public static class ModifyAssistantRequestResponseLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyAssistantRequestResponseLanguage value)
        {
            return value switch
            {
                ModifyAssistantRequestResponseLanguage.Arabic => "arabic",
                ModifyAssistantRequestResponseLanguage.Dutch => "dutch",
                ModifyAssistantRequestResponseLanguage.English => "english",
                ModifyAssistantRequestResponseLanguage.French => "french",
                ModifyAssistantRequestResponseLanguage.German => "german",
                ModifyAssistantRequestResponseLanguage.Hebrew => "hebrew",
                ModifyAssistantRequestResponseLanguage.Italian => "italian",
                ModifyAssistantRequestResponseLanguage.Portuguese => "portuguese",
                ModifyAssistantRequestResponseLanguage.Spanish => "spanish",
                ModifyAssistantRequestResponseLanguage.Unset => "unset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyAssistantRequestResponseLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => ModifyAssistantRequestResponseLanguage.Arabic,
                "dutch" => ModifyAssistantRequestResponseLanguage.Dutch,
                "english" => ModifyAssistantRequestResponseLanguage.English,
                "french" => ModifyAssistantRequestResponseLanguage.French,
                "german" => ModifyAssistantRequestResponseLanguage.German,
                "hebrew" => ModifyAssistantRequestResponseLanguage.Hebrew,
                "italian" => ModifyAssistantRequestResponseLanguage.Italian,
                "portuguese" => ModifyAssistantRequestResponseLanguage.Portuguese,
                "spanish" => ModifyAssistantRequestResponseLanguage.Spanish,
                "unset" => ModifyAssistantRequestResponseLanguage.Unset,
                _ => null,
            };
        }
    }
}