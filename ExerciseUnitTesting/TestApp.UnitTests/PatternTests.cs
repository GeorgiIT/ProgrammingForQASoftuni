using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[]? inputArray = { 1, 2, 3, 4, 5, 6 };
        
        int[] actualResult = Pattern.SortInPattern(inputArray);
        int[] expectedResult = { 1, 6, 2, 5, 3, 4 };

        CollectionAssert.AreEqual(actualResult, expectedResult);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[]? inputArray = {  };

        int[] actualResult = Pattern.SortInPattern(inputArray);
        

        CollectionAssert.IsEmpty(actualResult);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[]? inputArray = { 5 };

        int[] actualResult = Pattern.SortInPattern(inputArray);


        CollectionAssert.AreEqual(actualResult, inputArray);
    }
}
