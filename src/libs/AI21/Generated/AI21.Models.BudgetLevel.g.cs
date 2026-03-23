
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum BudgetLevel
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetLevel value)
        {
            return value switch
            {
                BudgetLevel.High => "high",
                BudgetLevel.Low => "low",
                BudgetLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => BudgetLevel.High,
                "low" => BudgetLevel.Low,
                "medium" => BudgetLevel.Medium,
                _ => null,
            };
        }
    }
}