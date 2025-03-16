
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum MaestroRunResultStatus
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
    public static class MaestroRunResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MaestroRunResultStatus value)
        {
            return value switch
            {
                MaestroRunResultStatus.Completed => "completed",
                MaestroRunResultStatus.Failed => "failed",
                MaestroRunResultStatus.InProgress => "in_progress",
                MaestroRunResultStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MaestroRunResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => MaestroRunResultStatus.Completed,
                "failed" => MaestroRunResultStatus.Failed,
                "in_progress" => MaestroRunResultStatus.InProgress,
                "requires_action" => MaestroRunResultStatus.RequiresAction,
                _ => null,
            };
        }
    }
}