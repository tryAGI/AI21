
#nullable enable

namespace AI21
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum OutputOptions
    {
        /// <summary>
        /// 
        /// </summary>
        DataSources,
        /// <summary>
        /// 
        /// </summary>
        RequirementsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputOptions value)
        {
            return value switch
            {
                OutputOptions.DataSources => "data_sources",
                OutputOptions.RequirementsResult => "requirements_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputOptions? ToEnum(string value)
        {
            return value switch
            {
                "data_sources" => OutputOptions.DataSources,
                "requirements_result" => OutputOptions.RequirementsResult,
                _ => null,
            };
        }
    }
}