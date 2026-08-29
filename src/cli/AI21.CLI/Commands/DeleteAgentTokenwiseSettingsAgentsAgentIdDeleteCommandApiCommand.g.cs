#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class DeleteAgentTokenwiseSettingsAgentsAgentIdDeleteCommandApiCommand
{
    private static Argument<string> AgentId { get; } = new(
        name: @"agent-id")
    {
        Description = @"",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-agent-tokenwise-settings-agents-agent-id-delete", @"Delete Agent");
                        command.Arguments.Add(AgentId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var agentId = parseResult.GetRequiredValue(AgentId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DeleteAgentTokenwiseSettingsAgentsAgentIdDeleteAsync(
                                    agentId: agentId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}