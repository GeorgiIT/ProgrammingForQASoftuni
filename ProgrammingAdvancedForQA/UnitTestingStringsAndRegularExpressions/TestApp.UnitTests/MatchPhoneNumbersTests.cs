using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        string expectedResults = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResults));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        string phoneNumbers = "+359-2-1224-56718, +359 2 86 5432, +359-2-555-555";
        string expectedResults = "";
        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResults));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        string phoneNumbers = "";
        string expectedResults = "";
        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResults));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        string phoneNumbers = "+359-2-124-5678, +359 2 986-5432, +359-2-555-5555, +359/2/555/5555";
        string expectedResults = "+359-2-124-5678, +359-2-555-5555";
        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResults));
    }
}
