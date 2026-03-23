
#nullable enable

namespace AI21
{
    /// <summary>
    /// Default Value: main
    /// </summary>
    public enum CreateMaestroRunsPayloadVariant
    {
        /// <summary>
        /// 
        /// </summary>
        Ingestion,
        /// <summary>
        /// 
        /// </summary>
        Main,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMaestroRunsPayloadVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMaestroRunsPayloadVariant value)
        {
            return value switch
            {
                CreateMaestroRunsPayloadVariant.Ingestion => "ingestion",
                CreateMaestroRunsPayloadVariant.Main => "main",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMaestroRunsPayloadVariant? ToEnum(string value)
        {
            return value switch
            {
                "ingestion" => CreateMaestroRunsPayloadVariant.Ingestion,
                "main" => CreateMaestroRunsPayloadVariant.Main,
                _ => null,
            };
        }
    }
}