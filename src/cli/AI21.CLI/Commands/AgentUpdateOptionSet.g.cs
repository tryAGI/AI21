#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record AgentUpdateOptionSet(
    Option<string?> NameOption,
                     Option<string?> Kind,
                     Option<string?> DescriptionOption,
                     Option<string?> ConfigId,
                     Option<bool?> Enabled)
{
    public static AgentUpdateOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AgentUpdateOptionSet(
                        NameOption: new Option<string?>($"--{normalizedPrefix}name")
                {
                    Description = @"",
                },
                Kind: new Option<string?>($"--{normalizedPrefix}kind")
                {
                    Description = @"",
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"",
                },
                ConfigId: new Option<string?>($"--{normalizedPrefix}config-id")
                {
                    Description = @"",
                },
                Enabled: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}enabled", description: @"")
        );
    }
}