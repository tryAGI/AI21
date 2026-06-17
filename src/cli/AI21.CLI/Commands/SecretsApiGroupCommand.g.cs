#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static class SecretsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"secrets", @"Secrets endpoint commands.");
                         command.Subcommands.Add(SecretsV1SecretStorageCommandApiCommand.Create());
                         command.Subcommands.Add(SecretsV1SecretStorage2CommandApiCommand.Create());
                         command.Subcommands.Add(SecretsV1SecretStorage3CommandApiCommand.Create());
                         command.Subcommands.Add(SecretsV1SecretStorage4CommandApiCommand.Create());
        return command;
    }
}