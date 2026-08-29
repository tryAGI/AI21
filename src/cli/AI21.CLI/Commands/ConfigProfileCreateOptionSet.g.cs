#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record ConfigProfileCreateOptionSet(
    Option<string> ConfigId,
                     Option<string?> NameOption,
                     Option<string?> DescriptionOption,
                     Option<bool?> Enabled)
{
    public static ConfigProfileCreateOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ConfigProfileCreateOptionSet(
                        ConfigId: new Option<string>($"--{normalizedPrefix}config-id")
                {
                    Description = @"",
                    Required = true,
                },
                NameOption: new Option<string?>($"--{normalizedPrefix}name")
                {
                    Description = @"",
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"",
                },
                Enabled: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}enabled", description: @"")
        );
    }
}