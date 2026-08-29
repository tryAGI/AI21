#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class GenerateResponsePdfStudioV1DemosRfiGenerateResponsePdfPostAsBytesCommandApiCommand
{
    private static readonly MarkdownRequestOptionSet MarkdownRequestOptionSetOptions = MarkdownRequestOptionSet.Create();

    public static Command Create()
    {
        var command = new Command(@"generate-response-pdf-studio-v1-demos-rfi-generate-response-pdf-post-as-bytes", @"Combine section answers ➜ styled PDF for download");
                        command.Options.Add(MarkdownRequestOptionSetOptions.Text);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var text = parseResult.GetRequiredValue(MarkdownRequestOptionSetOptions.Text);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GenerateResponsePdfStudioV1DemosRfiGenerateResponsePdfPostAsBytesAsync(
                                    text: text,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}