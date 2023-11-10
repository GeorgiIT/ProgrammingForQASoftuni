using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    // TODO: finish the test
    [TestCase("georgi@gmail.com")]
    [TestCase("gs@some.co.uk")]
    [TestCase("mail@some.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("somemai.com")]
    [TestCase("some@mailcom")]
    [TestCase("@a.com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
