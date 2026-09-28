#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class JambaCompleteApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"jamba-complete", @"Jamba Complete endpoint commands.");
                         command.Subcommands.Add(JambaCompleteV1ChatCompleteCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}