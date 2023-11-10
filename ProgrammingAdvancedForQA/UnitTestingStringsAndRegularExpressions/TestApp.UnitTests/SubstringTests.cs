using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        string expectedResult = "The quick brown jumps over the lazy dog";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "The";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        string expectedResult = "quick brown fox jumps over lazy dog";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        string expectedResult = "The quick brown fox jumps over the lazy";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "dog";
        string input = "dog dogdog dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        string expectedResult = "";

        // Assert

        Assert.AreEqual(expectedResult, result);
    }
}
