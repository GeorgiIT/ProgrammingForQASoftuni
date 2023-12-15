using System;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        string sender = "Georgi";
        string message = "Hello";
        _chatRoom.SendMessage(sender, message);

        string result = _chatRoom.DisplayChat();

        Assert.That(result.Contains("Georgi: Hello - Sent at "));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {

        string result = _chatRoom.DisplayChat();

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        string sender = "Georgi";
        string message = "Hello";
        string sender2 = "Antoniya";
        string message2 = "Hi!";
        _chatRoom.SendMessage(sender, message);
        _chatRoom.SendMessage(sender2, message2);

        string result = _chatRoom.DisplayChat();


        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result.Contains("Georgi: Hello - Sent at "));
        Assert.That(result.Contains("Antoniya: Hi! - Sent at "));
    }
}
