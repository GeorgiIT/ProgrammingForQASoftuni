using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        int[] input = { };

        // Act
        string result = CountRealNumbers.Count(input);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        int[] input = { 2 };

        // Act
        string result = CountRealNumbers.Count(input);
        string expected = "2 -> 1";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        int[] input = { 2, 5, 2, 8, 1 };

        // Act
        string result = CountRealNumbers.Count(input);
        string expected = "1 -> 1\r\n2 -> 2\r\n5 -> 1\r\n8 -> 1";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        int[] input = { -2, -2, -8, 5 };

        // Act
        string result = CountRealNumbers.Count(input);
        string expected = "-8 -> 1\r\n-2 -> 2\r\n5 -> 1";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {

        int[] input = { 0, 0, 2 };

        // Act
        string result = CountRealNumbers.Count(input);
        string expected = "0 -> 2\r\n2 -> 1";

        Assert.That(result, Is.EqualTo(expected));
    }
}
