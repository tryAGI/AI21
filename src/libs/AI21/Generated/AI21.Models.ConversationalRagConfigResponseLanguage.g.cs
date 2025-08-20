
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: english
    /// </summary>
    public enum ConversationalRagConfigResponseLanguage
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationalRagConfigResponseLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationalRagConfigResponseLanguage value)
        {
            return value switch
            {
                ConversationalRagConfigResponseLanguage.Arabic => "arabic",
                ConversationalRagConfigResponseLanguage.Dutch => "dutch",
                ConversationalRagConfigResponseLanguage.English => "english",
                ConversationalRagConfigResponseLanguage.French => "french",
                ConversationalRagConfigResponseLanguage.German => "german",
                ConversationalRagConfigResponseLanguage.Hebrew => "hebrew",
                ConversationalRagConfigResponseLanguage.Italian => "italian",
                ConversationalRagConfigResponseLanguage.Portuguese => "portuguese",
                ConversationalRagConfigResponseLanguage.Spanish => "spanish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationalRagConfigResponseLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => ConversationalRagConfigResponseLanguage.Arabic,
                "dutch" => ConversationalRagConfigResponseLanguage.Dutch,
                "english" => ConversationalRagConfigResponseLanguage.English,
                "french" => ConversationalRagConfigResponseLanguage.French,
                "german" => ConversationalRagConfigResponseLanguage.German,
                "hebrew" => ConversationalRagConfigResponseLanguage.Hebrew,
                "italian" => ConversationalRagConfigResponseLanguage.Italian,
                "portuguese" => ConversationalRagConfigResponseLanguage.Portuguese,
                "spanish" => ConversationalRagConfigResponseLanguage.Spanish,
                _ => null,
            };
        }
    }
}