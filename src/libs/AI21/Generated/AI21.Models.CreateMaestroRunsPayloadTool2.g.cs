
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMaestroRunsPayloadTool2
    {
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
    public static class CreateMaestroRunsPayloadTool2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMaestroRunsPayloadTool2 value)
        {
            return value switch
            {
                CreateMaestroRunsPayloadTool2.FileSearch => "file_search",
                CreateMaestroRunsPayloadTool2.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMaestroRunsPayloadTool2? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => CreateMaestroRunsPayloadTool2.FileSearch,
                "web_search" => CreateMaestroRunsPayloadTool2.WebSearch,
                _ => null,
            };
        }
    }
}