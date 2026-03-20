# Chat Client Get Service Returns Null For Unknown Key



This example assumes `using AI21;` is in scope and `apiKey` contains your AI21 API key.

```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var result = chatClient.GetService<ChatClientMetadata>(serviceKey: "unknown");
```