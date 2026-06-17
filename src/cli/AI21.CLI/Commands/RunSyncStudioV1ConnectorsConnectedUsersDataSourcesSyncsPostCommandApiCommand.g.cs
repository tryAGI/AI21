#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class RunSyncStudioV1ConnectorsConnectedUsersDataSourcesSyncsPostCommandApiCommand
{
    private static Option<string> Token { get; } = new(
        name: @"--token")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> DataSource { get; } = new(
        name: @"--data-source")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> OrganizationId { get; } = new(
        name: @"--organization-id")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Pipeline { get; } = new(
        name: @"--pipeline")
    {
        Description = @"",
        Required = true,
    };

    private static Option<object?> Configuration { get; } = new(
        name: @"--configuration")
    {
        Description = @"",
    };

    private static Option<string?> ConfigurationName { get; } = new(
        name: @"--configuration-name")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"run-sync-studio-v1-connectors-connected-users-data-sources-syncs-post", @"Run Sync");
                        command.Options.Add(Token);
                        command.Options.Add(DataSource);
                        command.Options.Add(OrganizationId);
                        command.Options.Add(Pipeline);
                        command.Options.Add(Configuration);
                        command.Options.Add(ConfigurationName);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.ConnectorsSyncParams>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var token = parseResult.GetRequiredValue(Token);
                        var dataSource = parseResult.GetRequiredValue(DataSource);
                        var organizationId = parseResult.GetRequiredValue(OrganizationId);
                        var pipeline = parseResult.GetRequiredValue(Pipeline);
                        var configuration = CliRuntime.WasSpecified(parseResult, Configuration) ? parseResult.GetValue(Configuration) : (__requestBase is { } __ConfigurationBaseValue ? __ConfigurationBaseValue.Configuration : default);
                        var configurationName = CliRuntime.WasSpecified(parseResult, ConfigurationName) ? parseResult.GetValue(ConfigurationName) : (__requestBase is { } __ConfigurationNameBaseValue ? __ConfigurationNameBaseValue.ConfigurationName : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.RunSyncStudioV1ConnectorsConnectedUsersDataSourcesSyncsPostAsync(
                                    token: token,
                                    dataSource: dataSource,
                                    organizationId: organizationId,
                                    pipeline: pipeline,
                                    configuration: configuration,
                                    configurationName: configurationName,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AI21.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}