
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum RunOptimization
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        Latency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunOptimizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunOptimization value)
        {
            return value switch
            {
                RunOptimization.Cost => "cost",
                RunOptimization.Latency => "latency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunOptimization? ToEnum(string value)
        {
            return value switch
            {
                "cost" => RunOptimization.Cost,
                "latency" => RunOptimization.Latency,
                _ => null,
            };
        }
    }
}