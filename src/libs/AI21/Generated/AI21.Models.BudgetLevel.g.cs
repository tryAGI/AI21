
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
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
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
                BudgetLevel.Low => "low",
                BudgetLevel.Medium => "medium",
                BudgetLevel.High => "high",
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
                "low" => BudgetLevel.Low,
                "medium" => BudgetLevel.Medium,
                "high" => BudgetLevel.High,
                _ => null,
            };
        }
    }
}