
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: unset
    /// </summary>
    public enum FileSearchToolResourceResponseLanguage
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
    public static class FileSearchToolResourceResponseLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchToolResourceResponseLanguage value)
        {
            return value switch
            {
                FileSearchToolResourceResponseLanguage.Arabic => "arabic",
                FileSearchToolResourceResponseLanguage.Dutch => "dutch",
                FileSearchToolResourceResponseLanguage.English => "english",
                FileSearchToolResourceResponseLanguage.French => "french",
                FileSearchToolResourceResponseLanguage.German => "german",
                FileSearchToolResourceResponseLanguage.Hebrew => "hebrew",
                FileSearchToolResourceResponseLanguage.Italian => "italian",
                FileSearchToolResourceResponseLanguage.Portuguese => "portuguese",
                FileSearchToolResourceResponseLanguage.Spanish => "spanish",
                FileSearchToolResourceResponseLanguage.Unset => "unset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchToolResourceResponseLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => FileSearchToolResourceResponseLanguage.Arabic,
                "dutch" => FileSearchToolResourceResponseLanguage.Dutch,
                "english" => FileSearchToolResourceResponseLanguage.English,
                "french" => FileSearchToolResourceResponseLanguage.French,
                "german" => FileSearchToolResourceResponseLanguage.German,
                "hebrew" => FileSearchToolResourceResponseLanguage.Hebrew,
                "italian" => FileSearchToolResourceResponseLanguage.Italian,
                "portuguese" => FileSearchToolResourceResponseLanguage.Portuguese,
                "spanish" => FileSearchToolResourceResponseLanguage.Spanish,
                "unset" => FileSearchToolResourceResponseLanguage.Unset,
                _ => null,
            };
        }
    }
}