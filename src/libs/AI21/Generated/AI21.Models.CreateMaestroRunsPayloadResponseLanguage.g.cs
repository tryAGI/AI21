
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMaestroRunsPayloadResponseLanguage
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
    public static class CreateMaestroRunsPayloadResponseLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMaestroRunsPayloadResponseLanguage value)
        {
            return value switch
            {
                CreateMaestroRunsPayloadResponseLanguage.Arabic => "arabic",
                CreateMaestroRunsPayloadResponseLanguage.Dutch => "dutch",
                CreateMaestroRunsPayloadResponseLanguage.English => "english",
                CreateMaestroRunsPayloadResponseLanguage.French => "french",
                CreateMaestroRunsPayloadResponseLanguage.German => "german",
                CreateMaestroRunsPayloadResponseLanguage.Hebrew => "hebrew",
                CreateMaestroRunsPayloadResponseLanguage.Italian => "italian",
                CreateMaestroRunsPayloadResponseLanguage.Portuguese => "portuguese",
                CreateMaestroRunsPayloadResponseLanguage.Spanish => "spanish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMaestroRunsPayloadResponseLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => CreateMaestroRunsPayloadResponseLanguage.Arabic,
                "dutch" => CreateMaestroRunsPayloadResponseLanguage.Dutch,
                "english" => CreateMaestroRunsPayloadResponseLanguage.English,
                "french" => CreateMaestroRunsPayloadResponseLanguage.French,
                "german" => CreateMaestroRunsPayloadResponseLanguage.German,
                "hebrew" => CreateMaestroRunsPayloadResponseLanguage.Hebrew,
                "italian" => CreateMaestroRunsPayloadResponseLanguage.Italian,
                "portuguese" => CreateMaestroRunsPayloadResponseLanguage.Portuguese,
                "spanish" => CreateMaestroRunsPayloadResponseLanguage.Spanish,
                _ => null,
            };
        }
    }
}