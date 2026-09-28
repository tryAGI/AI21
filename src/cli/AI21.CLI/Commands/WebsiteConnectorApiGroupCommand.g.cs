#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class WebsiteConnectorApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"website-connector", @"Website Connector endpoint commands.");
                         command.Subcommands.Add(WebsiteConnectorV1WebsiteConnectorCreateConfigCommandApiCommand.Create());
                         command.Subcommands.Add(WebsiteConnectorV1WebsiteConnectorGetConfigCommandApiCommand.Create());
                         command.Subcommands.Add(WebsiteConnectorV1WebsiteConnectorGetUrlStatusCommandApiCommand.Create());
                         command.Subcommands.Add(WebsiteConnectorV1WebsiteConnectorGetWebsiteStatusCommandApiCommand.Create());
                         command.Subcommands.Add(WebsiteConnectorV1WebsiteConnectorIngestUrlCommandApiCommand.Create());
                         command.Subcommands.Add(WebsiteConnectorV1WebsiteConnectorIngestWebsiteCommandApiCommand.Create());
                         command.Subcommands.Add(WebsiteConnectorV1WebsiteConnectorRetryIngestWebsiteCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}