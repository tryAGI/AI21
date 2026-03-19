namespace AI21.IntegrationTests;

[TestClass]
public partial class Tests
{
    public static Ai21Client GetAuthorizedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("AI21_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("AI21_API_KEY environment variable is not found.");

        return new Ai21Client(apiKey);
    }

    private static Ai21Client CreateTestClient() => new(apiKey: "test-key");
}
