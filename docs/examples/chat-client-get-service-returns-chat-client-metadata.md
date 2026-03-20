# Chat Client Get Service Returns Chat Client Metadata



This example assumes `using AI21;` is in scope and `apiKey` contains your AI21 API key.

```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var metadata = chatClient.GetService<ChatClientMetadata>();
```