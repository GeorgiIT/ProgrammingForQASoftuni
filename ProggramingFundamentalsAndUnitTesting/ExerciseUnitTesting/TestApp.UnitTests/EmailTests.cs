using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool actual = Email.IsValidEmail(validEmail);
        // Assert

        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string validEmail = "testexample.com";

        // Act
        bool actual = Email.IsValidEmail(validEmail);
        // Assert

        Assert.That(actual, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string validEmail = "";

        // Act
        bool actual = Email.IsValidEmail(validEmail);
        // Assert

        Assert.That(actual, Is.False);
    }
}
