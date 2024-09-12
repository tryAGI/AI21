
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum RunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatus value)
        {
            return value switch
            {
                RunStatus.Cancelled => "cancelled",
                RunStatus.Cancelling => "cancelling",
                RunStatus.Completed => "completed",
                RunStatus.Expired => "expired",
                RunStatus.Failed => "failed",
                RunStatus.Incomplete => "incomplete",
                RunStatus.InProgress => "in_progress",
                RunStatus.Queued => "queued",
                RunStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => RunStatus.Cancelled,
                "cancelling" => RunStatus.Cancelling,
                "completed" => RunStatus.Completed,
                "expired" => RunStatus.Expired,
                "failed" => RunStatus.Failed,
                "incomplete" => RunStatus.Incomplete,
                "in_progress" => RunStatus.InProgress,
                "queued" => RunStatus.Queued,
                "requires_action" => RunStatus.RequiresAction,
                _ => null,
            };
        }
    }
}