#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(DefaultApiGroupCommand.Create());
                         command.Subcommands.Add(JambaCompleteApiGroupCommand.Create());
                         command.Subcommands.Add(LibraryManagementApiGroupCommand.Create());
                         command.Subcommands.Add(RAGEngineApiGroupCommand.Create());
                         command.Subcommands.Add(SecretsApiGroupCommand.Create());
                         command.Subcommands.Add(WebsiteConnectorApiGroupCommand.Create());
        return command;
    }
}