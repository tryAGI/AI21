#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class UpdateWorkspaceModelEndpointStudioV1SettingsModelsNamePatchCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"",
    };

    private static Option<string?> RequestName { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<string?> ModelType { get; } = new(
        name: @"--model-type")
    {
        Description = @"",
    };

    private static Option<string?> SecretId { get; } = new(
        name: @"--secret-id")
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

                    private static string FormatResponse(ParseResult parseResult, global::AI21.WorkspaceModelResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AI21.WorkspaceModelResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-workspace-model-endpoint-studio-v1-settings-models-name-patch", @"Update Workspace Model Endpoint");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(RequestName);
                        command.Options.Add(ModelType);
                        command.Options.Add(SecretId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.WorkspaceModelUpdate>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var requestName = CliRuntime.WasSpecified(parseResult, RequestName) ? parseResult.GetValue(RequestName) : (__requestBase is { } __RequestNameBaseValue ? __RequestNameBaseValue.Name : default);
                        var modelType = CliRuntime.WasSpecified(parseResult, ModelType) ? parseResult.GetValue(ModelType) : (__requestBase is { } __ModelTypeBaseValue ? __ModelTypeBaseValue.ModelType : default);
                        var secretId = CliRuntime.WasSpecified(parseResult, SecretId) ? parseResult.GetValue(SecretId) : (__requestBase is { } __SecretIdBaseValue ? __SecretIdBaseValue.SecretId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UpdateWorkspaceModelEndpointStudioV1SettingsModelsNamePatchAsync(
                                    name: name,
                                    requestName: requestName,
                                    modelType: modelType,
                                    secretId: secretId,
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