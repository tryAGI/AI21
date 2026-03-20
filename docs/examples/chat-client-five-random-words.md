# Chat Client Five Random Words



This example assumes `using AI21;` is in scope and `apiKey` contains your AI21 API key.

```csharp
using var client = GetAuthorizedClient();

IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User, "Generate 5 random words.")
    ],
    new ChatOptions
    {
        ModelId = "jamba-large",
    });
```