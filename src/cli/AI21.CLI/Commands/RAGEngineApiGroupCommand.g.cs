#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class RAGEngineApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"rag-engine", @"RAG Engine endpoint commands.");
                         command.Subcommands.Add(RagEngineV1LibraryManagementCommandApiCommand.Create());
                         command.Subcommands.Add(RagEngineV1LibraryManagement2CommandApiCommand.Create());
                         command.Subcommands.Add(RagEngineV1LibraryManagement3CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}