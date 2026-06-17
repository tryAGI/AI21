#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class UpdateDemoStudioV1DemosDemoIdPutCommandApiCommand
{
    private static Argument<string> DemoId { get; } = new(
        name: @"demo-id")
    {
        Description = @"",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Name of the demo",
    };

    private static Option<global::AI21.DemoVisibility?> Visibility { get; } = new(
        name: @"--visibility")
    {
        Description = @"Visibility of the demo (public/private)",
    };

    private static Option<global::AI21.DemoStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Status of the demo (active/inactive)",
    };

    private static Option<object?> Config { get; } = new(
        name: @"--config")
    {
        Description = @"Demo configuration",
    };

    private static Option<string?> UiComponentName { get; } = new(
        name: @"--ui-component-name")
    {
        Description = @"Name of the UI component",
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

                    private static string FormatResponse(ParseResult parseResult, global::AI21.Demo value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.Demo value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-demo-studio-v1-demos-demo-id-put", @"Update Demo
Update an existing demo.");
                        command.Arguments.Add(DemoId);
                        command.Options.Add(NameOption);
                        command.Options.Add(Visibility);
                        command.Options.Add(Status);
                        command.Options.Add(Config);
                        command.Options.Add(UiComponentName);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.DemoUpdate>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var demoId = parseResult.GetRequiredValue(DemoId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var visibility = CliRuntime.WasSpecified(parseResult, Visibility) ? parseResult.GetValue(Visibility) : (__requestBase is { } __VisibilityBaseValue ? __VisibilityBaseValue.Visibility : default);
                        var status = CliRuntime.WasSpecified(parseResult, Status) ? parseResult.GetValue(Status) : (__requestBase is { } __StatusBaseValue ? __StatusBaseValue.Status : default);
                        var config = CliRuntime.WasSpecified(parseResult, Config) ? parseResult.GetValue(Config) : (__requestBase is { } __ConfigBaseValue ? __ConfigBaseValue.Config : default);
                        var uiComponentName = CliRuntime.WasSpecified(parseResult, UiComponentName) ? parseResult.GetValue(UiComponentName) : (__requestBase is { } __UiComponentNameBaseValue ? __UiComponentNameBaseValue.UiComponentName : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UpdateDemoStudioV1DemosDemoIdPutAsync(
                                    demoId: demoId,
                                    name: name,
                                    visibility: visibility,
                                    status: status,
                                    config: config,
                                    uiComponentName: uiComponentName,
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