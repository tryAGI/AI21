#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class SecretsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"secrets", @"Secrets endpoint commands.");
                         command.Subcommands.Add(SecretsV1SecretStorageCommandApiCommand.Create());
                         command.Subcommands.Add(SecretsV1SecretStorage2CommandApiCommand.Create());
                         command.Subcommands.Add(SecretsV1SecretStorage3CommandApiCommand.Create());
                         command.Subcommands.Add(SecretsV1SecretStorage4CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}