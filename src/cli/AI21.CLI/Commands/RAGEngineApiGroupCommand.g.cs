#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static class RAGEngineApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"rag-engine", @"RAG Engine endpoint commands.");
                         command.Subcommands.Add(RagEngineV1LibraryManagementCommandApiCommand.Create());
                         command.Subcommands.Add(RagEngineV1LibraryManagement2CommandApiCommand.Create());
                         command.Subcommands.Add(RagEngineV1LibraryManagement3CommandApiCommand.Create());
        return command;
    }
}