using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        char first = 'A';
        char second = 'B';
        string result = "";
        string output = CharacterRange.GetRange(first, second);


        Assert.That(result, Is.EqualTo(output));


    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        char first = 'A';
        char second = 'B';
        string result = "";
        string output = CharacterRange.GetRange(second, first);


        Assert.That(result, Is.EqualTo(output));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        char first = 'A';
        char second = 'C';
        string result = "B";
        string output = CharacterRange.GetRange(first, second);


        Assert.That(result, Is.EqualTo(output));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        char first = 'D';
        char second = 'G';
        string result = "E F";
        string output = CharacterRange.GetRange(first, second);


        Assert.That(result, Is.EqualTo(output));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        char first = 'X';
        char second = 'Z';
        string result = "Y";
        string output = CharacterRange.GetRange(first, second);


        Assert.That(result, Is.EqualTo(output));
    }
}
