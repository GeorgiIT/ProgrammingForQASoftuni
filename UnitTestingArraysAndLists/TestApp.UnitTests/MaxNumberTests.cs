using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MaxNumber.FindMax(nullList));
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        Assert.Throws<ArgumentException>(() => MaxNumber.FindMax(emptyList));
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> el = new List<int> { 1 };
        

        int result = MaxNumber.FindMax(el);

        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> elements = new List<int> { 1, 2, 3, 4, 5 };

        int maxNum = MaxNumber.FindMax(elements);

        Assert.That(maxNum, Is.EqualTo(5));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> elements = new List<int> { -1, -2, -3, -4, -5 };

        int maxNum = MaxNumber.FindMax(elements);

        Assert.That(maxNum, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> elements = new List<int> { 12, 2, 34, 42, 5 };

        int maxNum = MaxNumber.FindMax(elements);

        Assert.That(maxNum, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> elements = new List<int> { 12, 2, 34, 42, 42 };

        int maxNum = MaxNumber.FindMax(elements);

        Assert.That(maxNum, Is.EqualTo(42));
    }
}
