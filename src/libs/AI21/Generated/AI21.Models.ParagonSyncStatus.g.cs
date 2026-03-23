
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
        Active,
        /// <summary>
        /// 
        /// </summary>
        Errored,
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        Paused,
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
                ParagonSyncStatus.Active => "ACTIVE",
                ParagonSyncStatus.Errored => "ERRORED",
                ParagonSyncStatus.Idle => "IDLE",
                ParagonSyncStatus.Paused => "PAUSED",
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
                "ACTIVE" => ParagonSyncStatus.Active,
                "ERRORED" => ParagonSyncStatus.Errored,
                "IDLE" => ParagonSyncStatus.Idle,
                "PAUSED" => ParagonSyncStatus.Paused,
                _ => null,
            };
        }
    }
}