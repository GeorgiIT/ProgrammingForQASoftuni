using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new List<int>();

        // Act
        string result = Grouping.GroupNumbers(input);


        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { 1, 2, 4};

        // Act
        string result = Grouping.GroupNumbers(input);
        string expected = "Odd numbers: 1\r\nEven numbers: 2, 4";


        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() {  2, 4, 6, 8 };

        // Act
        string result = Grouping.GroupNumbers(input);
        string expected = "Even numbers: 2, 4, 6, 8";


        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { 1, 3, 5 };

        // Act
        string result = Grouping.GroupNumbers(input);
        string expected = "Odd numbers: 1, 3, 5";


        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new() { -1, -2, -4 };

        // Act
        string result = Grouping.GroupNumbers(input);
        string expected = "Odd numbers: -1\r\nEven numbers: -2, -4";


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
