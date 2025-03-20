
#nullable enable

namespace AI21
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMaestroRunsPayloadBudget
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
    public static class CreateMaestroRunsPayloadBudgetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMaestroRunsPayloadBudget value)
        {
            return value switch
            {
                CreateMaestroRunsPayloadBudget.Low => "low",
                CreateMaestroRunsPayloadBudget.Medium => "medium",
                CreateMaestroRunsPayloadBudget.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMaestroRunsPayloadBudget? ToEnum(string value)
        {
            return value switch
            {
                "low" => CreateMaestroRunsPayloadBudget.Low,
                "medium" => CreateMaestroRunsPayloadBudget.Medium,
                "high" => CreateMaestroRunsPayloadBudget.High,
                _ => null,
            };
        }
    }
}