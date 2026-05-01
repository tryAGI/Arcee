namespace Arcee.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ArceeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ARCEE_API_KEY") is { Length: > 0 } arceeKeyValue
                ? arceeKeyValue
                : Environment.GetEnvironmentVariable("ARCEEAI_API_KEY") is { Length: > 0 } arceeAiKeyValue
                ? arceeAiKeyValue
                : throw new AssertInconclusiveException("ARCEE_API_KEY or ARCEEAI_API_KEY environment variable is not found.");

        var client = new ArceeClient(apiKey);
        
        return client;
    }
}
