using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        string[] input = { "aba", "aba" };

        string result = OddOccurrences.FindOdd(input);
        string expected = "";

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] input = { "aba" };

        string result = OddOccurrences.FindOdd(input);
        string expected = "aba";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] input = { "aba", "ab", "ab", "ac", "ac", "ac" };

        string result = OddOccurrences.FindOdd(input);
        string expected = "aba ac";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] input = { "aBa", "ab", "ab", "Ac", "aC", "ac" };

        string result = OddOccurrences.FindOdd(input);
        string expected = "aba ac";

        Assert.That(result, Is.EqualTo(expected));
    }
}
