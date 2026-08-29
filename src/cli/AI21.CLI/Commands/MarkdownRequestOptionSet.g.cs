#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record MarkdownRequestOptionSet(
    Option<string> Text)
{
    public static MarkdownRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new MarkdownRequestOptionSet(
                        Text: new Option<string>($"--{normalizedPrefix}text")
                {
                    Description = @"All section answers concatenated",
                    Required = true,
                }
        );
    }
}