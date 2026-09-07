#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class DeleteProviderKeyTokenwiseSettingsProviderKeysDeleteCommandApiCommand
{
    private static Option<string> Provider { get; } = new(
        name: @"--provider")
    {
        Description = @"",
        Required = true,
    };

    public static Command Create()
    {
        var command = new Command(@"delete-provider-key-tokenwise-settings-provider-keys-delete", @"Delete Provider Key
Delete the workspace's key for a provider. 404 if none is configured.");
                        command.Options.Add(Provider);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var provider = parseResult.GetRequiredValue(Provider);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DeleteProviderKeyTokenwiseSettingsProviderKeysDeleteAsync(
                                    provider: provider,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}