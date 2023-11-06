using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] input = { '2', 'g', 'd' };

        char[] actualResult = Fake.RemoveStringNumbers(input);

        CollectionAssert.DoesNotContain(actualResult, '2');
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] input = { 'a', 'g', 'd' };

        char[] actualResult = Fake.RemoveStringNumbers(input);

        CollectionAssert.AreEqual(actualResult, input);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] input = { };

        char[] actualResult = Fake.RemoveStringNumbers(input);

        CollectionAssert.IsEmpty(actualResult);
    }
}
