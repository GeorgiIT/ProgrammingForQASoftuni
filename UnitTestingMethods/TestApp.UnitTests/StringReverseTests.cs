using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        StringReverse stringReverse = new StringReverse();
        string input = string.Empty;
        // Act
        StringReverse.Reverse(input);

        // Assert
       Assert.IsEmpty(input);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        StringReverse stringReverse = new StringReverse();
        string input = "a";
        // Act
        StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("a", input, "Characters are not the same!");
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        
        string input = "Softuni";
        // Act
        

        // Assert
        Assert.AreEqual("inutfoS", StringReverse.Reverse(input), "Characters are not the same!");
    }
}
