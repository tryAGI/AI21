
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum StatelessRunResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatelessRunResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatelessRunResultStatus value)
        {
            return value switch
            {
                StatelessRunResultStatus.Completed => "completed",
                StatelessRunResultStatus.Failed => "failed",
                StatelessRunResultStatus.InProgress => "in_progress",
                StatelessRunResultStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatelessRunResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => StatelessRunResultStatus.Completed,
                "failed" => StatelessRunResultStatus.Failed,
                "in_progress" => StatelessRunResultStatus.InProgress,
                "requires_action" => StatelessRunResultStatus.RequiresAction,
                _ => null,
            };
        }
    }
}