using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> oneElement = new List<int> { 5 };
        // Act
        List<int> result = GaussTrick.SumPairs(oneElement);

        // Assert
        CollectionAssert.AreEqual(oneElement, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> list = new List<int> { 5, 2, 6, 4 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> assertResult = new List<int> {9 , 8 };
        CollectionAssert.AreEqual(result, assertResult);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // TODO: finish the test
    }
}
