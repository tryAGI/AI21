namespace AI21.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task J2UltraChat()
    {
        using var api = GetAuthorizedApi();

        // await api.Completion.V1J2UltraCompleteAsync(
        //     messages:
        //     [
        //         new ChatMessage
        //         {
        //             Text = "Hello",
        //             Role = RoleType.User,
        //         }
        //     ],
        //     system: string.Empty,
        //     cancellationToken: CancellationToken.None);
    }
}
