using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 } , "5 5 13 13")]
    [TestCase(new int[] { -1, 2, 3, 4, 5, 6, 7, -8 }, "5 3 -3 13")]
    [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, "0 0 0 0")]
    [TestCase(new int[] { 1, 2, 3, 4 }, "3 7")]
    [TestCase(new int[] { -10, -5, -11, -12, -3, -4, -5, -5 }, "-16 -22 -8 -9")]
    [TestCase(new int[] {  }, "")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        

        string sum = FoldSum.FoldArray(arr);

        
        Assert.AreEqual(expected, sum);
    }
}
