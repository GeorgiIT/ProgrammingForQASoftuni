using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "Hello my name is George";
        string[] banText = {  };
        // Act

        string result = TextFilter.Filter(banText, text);
        string expectedResult = "Hello my name is George";

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string text = "Hello my name is George";
        string[] banText = { "name" };
        // Act

        string result = TextFilter.Filter(banText, text);
        string expectedResult = "Hello my **** is George";

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "Hello my name is George";
        string[] banText = { };
        // Act

        string result = TextFilter.Filter(banText, text);
        string expectedResult = "Hello my name is George";

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string text = "Hello my name is George";
        string[] banText = {"my name"};
        // Act

        string result = TextFilter.Filter(banText, text);
        string expectedResult = "Hello ******* is George";

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
