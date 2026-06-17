#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal sealed record WorkflowConfigOptionSet(
    Option<string> EndpointUrl)
{
    public static WorkflowConfigOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new WorkflowConfigOptionSet(
                        EndpointUrl: new Option<string>($"--{normalizedPrefix}endpoint-url")
                {
                    Description = @"",
                    Required = true,
                }
        );
    }
}