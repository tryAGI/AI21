#nullable enable

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static class LibraryManagementApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"library-management", @"Library management endpoint commands.");
                         command.Subcommands.Add(LibraryManagementV1LibraryDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LibraryManagementV1LibraryManagementCommandApiCommand.Create());
                         command.Subcommands.Add(LibraryManagementV1LibraryManagement2CommandApiCommand.Create());
                         command.Subcommands.Add(LibraryManagementV1LibraryManagement3CommandApiCommand.Create());
                         command.Subcommands.Add(LibraryManagementV1LibraryUploadCommandApiCommand.Create());
        return command;
    }
}