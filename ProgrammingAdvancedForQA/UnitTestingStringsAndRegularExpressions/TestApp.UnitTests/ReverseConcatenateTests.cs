using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        
        string[] input = { "" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expectedResult = "";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange

        string[] input = { "Hello" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expectedResult = "Hello";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange

        string[] input = { "Hello", "world" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expectedResult = "worldHello";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange

        string[] input = null;

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expectedResult = "";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange

        string[] input = { "H ello", " world" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expectedResult = " worldH ello";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange

        string[] input = { "1", "2","3","4", "5","6" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expectedResult = "654321";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }
}
