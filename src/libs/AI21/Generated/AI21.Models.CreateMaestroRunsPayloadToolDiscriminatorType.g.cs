
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMaestroRunsPayloadToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMaestroRunsPayloadToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMaestroRunsPayloadToolDiscriminatorType value)
        {
            return value switch
            {
                CreateMaestroRunsPayloadToolDiscriminatorType.Http => "http",
                CreateMaestroRunsPayloadToolDiscriminatorType.Mcp => "mcp",
                CreateMaestroRunsPayloadToolDiscriminatorType.FileSearch => "file_search",
                CreateMaestroRunsPayloadToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMaestroRunsPayloadToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "http" => CreateMaestroRunsPayloadToolDiscriminatorType.Http,
                "mcp" => CreateMaestroRunsPayloadToolDiscriminatorType.Mcp,
                "file_search" => CreateMaestroRunsPayloadToolDiscriminatorType.FileSearch,
                "web_search" => CreateMaestroRunsPayloadToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}