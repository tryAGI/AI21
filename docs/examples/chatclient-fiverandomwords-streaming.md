# ChatClient.FiveRandomWords.Streaming



This example assumes `using AI21;` is in scope and `apiKey` contains your AI21 API key.

```csharp
using var client = GetAuthorizedClient();

IChatClient chatClient = client;
var updates = chatClient.GetStreamingResponseAsync(
    [
        new ChatMessage(ChatRole.User, "Generate 5 random words.")
    ],
    new ChatOptions
    {
        ModelId = "jamba-large",
    });

var deltas = new List<string>();
await foreach (var update in updates)
{
    if (!string.IsNullOrWhiteSpace(update.Text))
    {
        deltas.Add(update.Text);
    }
}
```