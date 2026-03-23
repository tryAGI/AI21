
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
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
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType value)
        {
            return value switch
            {
                LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType.FileSearch => "file_search",
                LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType.Http => "http",
                LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType.Mcp => "mcp",
                LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType.FileSearch,
                "http" => LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType.Http,
                "mcp" => LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType.Mcp,
                "web_search" => LanguageStudioApiServerDataTypesExecutionEngineToolDefinitionDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}