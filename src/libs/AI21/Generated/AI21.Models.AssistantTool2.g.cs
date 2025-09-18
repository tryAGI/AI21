
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum AssistantTool2
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        PlanApproval,
        /// <summary>
        /// 
        /// </summary>
        Rag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantTool2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantTool2 value)
        {
            return value switch
            {
                AssistantTool2.FileSearch => "file_search",
                AssistantTool2.WebSearch => "web_search",
                AssistantTool2.PlanApproval => "plan_approval",
                AssistantTool2.Rag => "rag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantTool2? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => AssistantTool2.FileSearch,
                "web_search" => AssistantTool2.WebSearch,
                "plan_approval" => AssistantTool2.PlanApproval,
                "rag" => AssistantTool2.Rag,
                _ => null,
            };
        }
    }
}