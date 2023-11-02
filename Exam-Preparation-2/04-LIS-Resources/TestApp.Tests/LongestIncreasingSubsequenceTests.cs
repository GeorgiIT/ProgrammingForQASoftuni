using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        int[] arr = null;


        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(arr));
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        int[] arr = { };

        string result = LongestIncreasingSubsequence.GetLis(arr);

        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[] arr = { 0 };

        string result = LongestIncreasingSubsequence.GetLis(arr);

        Assert.That(result, Is.EqualTo("0"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[] arr = { 15, 0, 5 , 55, -6, 62 };

        string result = LongestIncreasingSubsequence.GetLis(arr);

        Assert.That(result, Is.EqualTo("0 5 55 62"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[] arr = { 2, 4, 6, 8, 10 };

        string result = LongestIncreasingSubsequence.GetLis(arr);

        Assert.That(result, Is.EqualTo("2 4 6 8 10"));
    }
}
