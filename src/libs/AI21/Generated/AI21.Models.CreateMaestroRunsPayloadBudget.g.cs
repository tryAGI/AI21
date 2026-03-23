
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
    public static class CreateMaestroRunsPayloadBudgetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMaestroRunsPayloadBudget value)
        {
            return value switch
            {
                CreateMaestroRunsPayloadBudget.High => "high",
                CreateMaestroRunsPayloadBudget.Low => "low",
                CreateMaestroRunsPayloadBudget.Medium => "medium",
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
                "high" => CreateMaestroRunsPayloadBudget.High,
                "low" => CreateMaestroRunsPayloadBudget.Low,
                "medium" => CreateMaestroRunsPayloadBudget.Medium,
                _ => null,
            };
        }
    }
}