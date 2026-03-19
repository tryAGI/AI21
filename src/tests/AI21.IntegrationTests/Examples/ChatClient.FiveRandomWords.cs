/*
order: 20
title: Chat Client Five Random Words
slug: chat-client-five-random-words
*/

using Microsoft.Extensions.AI;

namespace AI21.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords()
    {
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

        response.Messages.Should().ContainSingle();
        response.Text.Should().NotBeNullOrWhiteSpace();
        response.Messages[0].Role.Should().Be(ChatRole.Assistant);
        response.Messages[0].Text.Should().NotBeNullOrWhiteSpace();
    }
}
