#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class LibraryManagementV1LibraryUploadCommandApiCommand
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

    private static Option<string?> Path { get; } = new(
        name: @"--path")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Labels { get; } = new(
        name: @"--labels")
    {
        Description = @"",
    };

    private static Option<string?> PublicUrl { get; } = new(
        name: @"--public-url")
    {
        Description = @"",
    };

    private static Option<string?> CustomConfigs { get; } = new(
        name: @"--custom-configs")
    {
        Description = @"",
    };

    private static Option<global::AI21.UploadMode?> UploadMode { get; } = new(
        name: @"--upload-mode")
    {
        Description = @"",
    };

    private static Option<global::System.Guid?> BatchId { get; } = new(
        name: @"--batch-id")
    {
        Description = @"",
    };

    private static Option<string?> DataSource { get; } = new(
        name: @"--data-source")
    {
        Description = @"",
    };

    private static Option<string?> Metadata { get; } = new(
        name: @"--metadata")
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
        var command = new Command(@"v1-library-upload", @"Upload Workspace File
Upload files to use for [RAG Engine document searches](https://docs.ai21.com/docs/rag-engine-overview).
You can assign metadata to your files to limit searches to specific files by file metadata.
There is no bulk upload method; files must be loaded one at a time.

- **Max number of files:** No limit. The playground limits bulk uploads to 50 files per request.
- **Max library size:** 1 GB total size. No limit to individual file size.
- **Supported file types:** PDF, DocX, HTML, TXT");
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(Path);
                        command.Options.Add(Labels);
                        command.Options.Add(PublicUrl);
                        command.Options.Add(CustomConfigs);
                        command.Options.Add(UploadMode);
                        command.Options.Add(BatchId);
                        command.Options.Add(DataSource);
                        command.Options.Add(Metadata);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.BodyV1LibraryUpload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var file = parseResult.GetRequiredValue(File);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var path = CliRuntime.WasSpecified(parseResult, Path) ? parseResult.GetValue(Path) : (__requestBase is { } __PathBaseValue ? __PathBaseValue.Path : default);
                        var labels = CliRuntime.WasSpecified(parseResult, Labels) ? parseResult.GetValue(Labels) : (__requestBase is { } __LabelsBaseValue ? __LabelsBaseValue.Labels : default);
                        var publicUrl = CliRuntime.WasSpecified(parseResult, PublicUrl) ? parseResult.GetValue(PublicUrl) : (__requestBase is { } __PublicUrlBaseValue ? __PublicUrlBaseValue.PublicUrl : default);
                        var customConfigs = CliRuntime.WasSpecified(parseResult, CustomConfigs) ? parseResult.GetValue(CustomConfigs) : (__requestBase is { } __CustomConfigsBaseValue ? __CustomConfigsBaseValue.CustomConfigs : default);
                        var uploadMode = CliRuntime.WasSpecified(parseResult, UploadMode) ? parseResult.GetValue(UploadMode) : (__requestBase is { } __UploadModeBaseValue ? __UploadModeBaseValue.UploadMode : default);
                        var batchId = CliRuntime.WasSpecified(parseResult, BatchId) ? parseResult.GetValue(BatchId) : (__requestBase is { } __BatchIdBaseValue ? __BatchIdBaseValue.BatchId : default);
                        var dataSource = CliRuntime.WasSpecified(parseResult, DataSource) ? parseResult.GetValue(DataSource) : (__requestBase is { } __DataSourceBaseValue ? __DataSourceBaseValue.DataSource : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LibraryManagement.V1LibraryUploadAsync(
                                    file: file,
                                    filename: filename,
                                    path: path,
                                    labels: labels,
                                    publicUrl: publicUrl,
                                    customConfigs: customConfigs,
                                    uploadMode: uploadMode,
                                    batchId: batchId,
                                    dataSource: dataSource,
                                    metadata: metadata,
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