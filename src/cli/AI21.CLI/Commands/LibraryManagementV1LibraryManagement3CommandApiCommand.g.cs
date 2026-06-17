#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class LibraryManagementV1LibraryManagement3CommandApiCommand
{
    private static Argument<global::System.Guid> FileId { get; } = new(
        name: @"file-id")
    {
        Description = @"",
    };

    private static Option<string?> PublicUrl { get; } = new(
        name: @"--public-url")
    {
        Description = @"The public URL of the file, if any. This URL is not validated by
AI21 or used in any way. It is strictly a piece of metadata that you can
optionally attach to a file.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Labels { get; } = new(
        name: @"--labels")
    {
        Description = @"Any labels to associate with this file. Separate multiple labels with commas. If
provided, will overwrite all existing labels.
",
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
        var command = new Command(@"v1-library-management3", @"Update File
Update the specified parameters of a specific document in the user's library.
This operation currently supports updating the publicUrl and labels parameters.

&gt; **This operation overwrites the specified items with the new data you provide.**
&gt; If you wish to add new labels to the labels list without removing the existing ones,
&gt; you must submit a labels list that includes both the current and new labels.**
&gt;
&gt; For instance, if the current labels are ""Label A"" and ""Label B"", and you wish to
&gt; add ""New Label C"" and ""New Label D"" to the list, you must specify `""labels"": [""Label A"", ""Label B"", ""New Label C"", ""New Label D""]`.");
                        command.Arguments.Add(FileId);
                        command.Options.Add(PublicUrl);
                        command.Options.Add(Labels);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AI21.FilesUpdateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AI21.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var fileId = parseResult.GetRequiredValue(FileId);
                        var publicUrl = CliRuntime.WasSpecified(parseResult, PublicUrl) ? parseResult.GetValue(PublicUrl) : (__requestBase is { } __PublicUrlBaseValue ? __PublicUrlBaseValue.PublicUrl : default);
                        var labels = CliRuntime.WasSpecified(parseResult, Labels) ? parseResult.GetValue(Labels) : (__requestBase is { } __LabelsBaseValue ? __LabelsBaseValue.Labels : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LibraryManagement.V1LibraryManagement3Async(
                                    fileId: fileId,
                                    publicUrl: publicUrl,
                                    labels: labels,
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