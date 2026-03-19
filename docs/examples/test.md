# Test



This example assumes `using AI21;` is in scope and `apiKey` contains your AI21 API key.

```csharp
using var api = GetAuthorizedClient();

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
```