using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.IsEmpty(numbers);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 3, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert

        CollectionAssert.AllItemsAreUnique(result);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] numbers = { 5, 5, 5, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert

        CollectionAssert.AllItemsAreUnique(result);
        Assert.That(result.Length, Is.EqualTo(1));
    }
}
