#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static class JambaCompleteApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"jamba-complete", @"Jamba Complete endpoint commands.");
                         command.Subcommands.Add(JambaCompleteV1ChatCompleteCommandApiCommand.Create());
        return command;
    }
}