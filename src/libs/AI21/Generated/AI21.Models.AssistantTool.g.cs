
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum AssistantTool
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantToolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantTool value)
        {
            return value switch
            {
                AssistantTool.FileSearch => "file_search",
                AssistantTool.WebSearch => "web_search",
                AssistantTool.PlanApproval => "plan_approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantTool? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => AssistantTool.FileSearch,
                "web_search" => AssistantTool.WebSearch,
                "plan_approval" => AssistantTool.PlanApproval,
                _ => null,
            };
        }
    }
}