#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record ProviderKeyUpdateOptionSet(
    Option<string> Provider,
                     Option<string> ApiKey)
{
    public static ProviderKeyUpdateOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ProviderKeyUpdateOptionSet(
                        Provider: new Option<string>($"--{normalizedPrefix}provider")
                {
                    Description = @"",
                    Required = true,
                },
                ApiKey: new Option<string>($"--{normalizedPrefix}api-key")
                {
                    Description = @"",
                    Required = true,
                }
        );
    }
}