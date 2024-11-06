
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ConnectorsWorkflowStatus
    {
        /// <summary>
        /// 
        /// </summary>
        INPROGRESS,
        /// <summary>
        /// 
        /// </summary>
        PARTIALLYCOMPLETED,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        SUCCEEDED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectorsWorkflowStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectorsWorkflowStatus value)
        {
            return value switch
            {
                ConnectorsWorkflowStatus.INPROGRESS => "IN_PROGRESS",
                ConnectorsWorkflowStatus.PARTIALLYCOMPLETED => "PARTIALLY_COMPLETED",
                ConnectorsWorkflowStatus.FAILED => "FAILED",
                ConnectorsWorkflowStatus.SUCCEEDED => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectorsWorkflowStatus? ToEnum(string value)
        {
            return value switch
            {
                "IN_PROGRESS" => ConnectorsWorkflowStatus.INPROGRESS,
                "PARTIALLY_COMPLETED" => ConnectorsWorkflowStatus.PARTIALLYCOMPLETED,
                "FAILED" => ConnectorsWorkflowStatus.FAILED,
                "SUCCEEDED" => ConnectorsWorkflowStatus.SUCCEEDED,
                _ => null,
            };
        }
    }
}