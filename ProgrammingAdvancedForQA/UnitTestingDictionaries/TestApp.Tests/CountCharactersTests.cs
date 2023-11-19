using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        List<string> input = new() { "1" };

        // Act
        string result = CountCharacters.Count(input);
        string expected = "1 -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "a", "ab", "abc" };

        // Act
        string result = CountCharacters.Count(input);
        string expected = "a -> 3\r\nb -> 2\r\nc -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "#", "@$", "_+=", "##" };

        // Act
        string result = CountCharacters.Count(input);
        string expected = "# -> 3\r\n@ -> 1\r\n$ -> 1\r\n_ -> 1\r\n+ -> 1\r\n= -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
