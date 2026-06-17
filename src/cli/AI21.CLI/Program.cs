#nullable enable

using System.CommandLine;
using AI21.CLI;
using AI21.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the AI21 SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(ApiCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);