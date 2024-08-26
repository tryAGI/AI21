namespace AI21.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public async Task Generate()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("AI21_API_KEY") ??
            throw new AssertInconclusiveException("AI21_API_KEY environment variable is not found.");

        using var api = new Ai21Api();
    }
}
