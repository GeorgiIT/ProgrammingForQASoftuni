using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31-Dec-2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "31dec22";
        string expected = "";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "31-Dec-2022, 31-Sep-2012, 12-Jul-2020";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;
        
        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
    }
}
