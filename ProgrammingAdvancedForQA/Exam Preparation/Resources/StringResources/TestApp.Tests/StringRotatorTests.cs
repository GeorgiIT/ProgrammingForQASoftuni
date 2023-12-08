using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        string input = string.Empty;
        int position = 0;

        string result = StringRotator.RotateRight(input, position);

        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        string input = "hello";
        int position = 0;

        string result = StringRotator.RotateRight(input, position);
        string expected = "hello";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        string input = "hello";
        int position = 1;

        string result = StringRotator.RotateRight(input, position);
        string expected = "ohell";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        string input = "hello";
        int position = -1;

        string result = StringRotator.RotateRight(input, position);
        string expected = "ohell";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        string input = "hello";
        int position = 7;

        string result = StringRotator.RotateRight(input, position);
        string expected = "lohel";

        Assert.That(result, Is.EqualTo(expected));
    }
}
