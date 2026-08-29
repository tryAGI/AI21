#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record InsightFeedbackInOptionSet(
    Option<string> Verdict,
                     Option<string?> Comment)
{
    public static InsightFeedbackInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new InsightFeedbackInOptionSet(
                        Verdict: new Option<string>($"--{normalizedPrefix}verdict")
                {
                    Description = @"",
                    Required = true,
                },
                Comment: new Option<string?>($"--{normalizedPrefix}comment")
                {
                    Description = @"",
                }
        );
    }
}