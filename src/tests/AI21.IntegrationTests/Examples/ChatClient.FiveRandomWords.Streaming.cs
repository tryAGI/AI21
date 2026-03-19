/*
order: 10
title: Chat Client Five Random Words Streaming
slug: chat-client-five-random-words-streaming
*/

using Microsoft.Extensions.AI;

namespace AI21.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords_Streaming()
    {
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

        deltas.Should().NotBeEmpty();
        string.Concat(deltas).Should().NotBeNullOrWhiteSpace();
    }
}
