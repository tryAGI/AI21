
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ParagonSyncStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ACTIVE,
        /// <summary>
        /// 
        /// </summary>
        IDLE,
        /// <summary>
        /// 
        /// </summary>
        ERRORED,
        /// <summary>
        /// 
        /// </summary>
        PAUSED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParagonSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParagonSyncStatus value)
        {
            return value switch
            {
                ParagonSyncStatus.ACTIVE => "ACTIVE",
                ParagonSyncStatus.IDLE => "IDLE",
                ParagonSyncStatus.ERRORED => "ERRORED",
                ParagonSyncStatus.PAUSED => "PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParagonSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ParagonSyncStatus.ACTIVE,
                "IDLE" => ParagonSyncStatus.IDLE,
                "ERRORED" => ParagonSyncStatus.ERRORED,
                "PAUSED" => ParagonSyncStatus.PAUSED,
                _ => null,
            };
        }
    }
}