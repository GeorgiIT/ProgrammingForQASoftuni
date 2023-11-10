using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("abv", 2, "aBvaBv")]
    [TestCase("HELLO" ,3 , "hElLohElLohElLo")]
    [TestCase("SomeRandomText", 1 , "sOmErAnDoMtExT")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        string input = string.Empty;
        int repetitionFactor = 2;

        


        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        string input = "SoftUni";
        int repetitionFactor = -2;




        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        string input = "SoftUni";
        int repetitionFactor = 0;




        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}
