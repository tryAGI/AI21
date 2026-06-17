#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class UploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePostCommandApiCommand
{
    private static Option<byte[]> File { get; } = new(
        name: @"--file")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> Budget { get; } = new(
        name: @"--budget")
    {
        Description = @"",
    };

    private static Option<string?> VectorStoreId { get; } = new(
        name: @"--vector-store-id")
    {
        Description = @"Vector store ID to use for RFI processing",
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
        var command = new Command(@"upload-check-compliance-studio-v1-demos-regulations-upload-check-compliance-post", @"Upload Check Compliance
Check compliance of a document file against regulatory requirements.");
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(Budget);
                        command.Options.Add(VectorStoreId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.BodyUploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePost>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var file = parseResult.GetRequiredValue(File);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var budget = CliRuntime.WasSpecified(parseResult, Budget) ? parseResult.GetValue(Budget) : (__requestBase is { } __BudgetBaseValue ? __BudgetBaseValue.Budget : default);
                        var vectorStoreId = CliRuntime.WasSpecified(parseResult, VectorStoreId) ? parseResult.GetValue(VectorStoreId) : (__requestBase is { } __VectorStoreIdBaseValue ? __VectorStoreIdBaseValue.VectorStoreId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UploadCheckComplianceStudioV1DemosRegulationsUploadCheckCompliancePostAsync(
                                    file: file,
                                    filename: filename,
                                    budget: budget,
                                    vectorStoreId: vectorStoreId,
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