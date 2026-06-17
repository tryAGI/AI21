#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record CreatePlanPayloadOptionSet(
    Option<string> Code)
{
    public static CreatePlanPayloadOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreatePlanPayloadOptionSet(
                        Code: new Option<string>($"--{normalizedPrefix}code")
                {
                    Description = @"",
                    Required = true,
                }
        );
    }
}