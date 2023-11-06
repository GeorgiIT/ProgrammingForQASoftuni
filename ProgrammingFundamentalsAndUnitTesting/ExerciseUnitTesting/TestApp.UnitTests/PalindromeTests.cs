using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> palindrome = new List<string>() { "ala" , "pop" };

        // Act
        bool result = Palindrome.IsPalindrome(palindrome);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> palindrome = new List<string>() { "ala" };

        // Act
        bool result = Palindrome.IsPalindrome(palindrome);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> palindrome = new List<string>() { "alabala" };

        // Act
        bool result = Palindrome.IsPalindrome(palindrome);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> palindrome = new List<string>() { "PoP", "BeeB" };

        // Act
        bool result = Palindrome.IsPalindrome(palindrome);

        // Assert
        Assert.IsTrue(result);
    }
}
