#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AI21.CLI.Commands;

internal static partial class DeleteConfigTokenwiseSettingsConfigsConfigIdDeleteCommandApiCommand
{
    private static Argument<string> ConfigId { get; } = new(
        name: @"config-id")
    {
        Description = @"",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-config-tokenwise-settings-configs-config-id-delete", @"Delete Config");
                        command.Arguments.Add(ConfigId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var configId = parseResult.GetRequiredValue(ConfigId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DeleteConfigTokenwiseSettingsConfigsConfigIdDeleteAsync(
                                    configId: configId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}