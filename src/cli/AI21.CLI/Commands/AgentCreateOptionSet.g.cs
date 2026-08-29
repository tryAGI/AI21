#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record AgentCreateOptionSet(
    Option<string> AgentId,
                     Option<string?> Kind,
                     Option<string?> NameOption,
                     Option<string?> DescriptionOption,
                     Option<string?> ConfigId,
                     Option<bool?> Enabled)
{
    public static AgentCreateOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AgentCreateOptionSet(
                        AgentId: new Option<string>($"--{normalizedPrefix}agent-id")
                {
                    Description = @"",
                    Required = true,
                },
                Kind: new Option<string?>($"--{normalizedPrefix}kind")
                {
                    Description = @"",
                },
                NameOption: new Option<string?>($"--{normalizedPrefix}name")
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