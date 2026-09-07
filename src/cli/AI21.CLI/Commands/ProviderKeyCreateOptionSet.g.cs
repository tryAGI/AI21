#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record ProviderKeyCreateOptionSet(
    Option<string> Provider,
                     Option<string> ApiKey)
{
    public static ProviderKeyCreateOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ProviderKeyCreateOptionSet(
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