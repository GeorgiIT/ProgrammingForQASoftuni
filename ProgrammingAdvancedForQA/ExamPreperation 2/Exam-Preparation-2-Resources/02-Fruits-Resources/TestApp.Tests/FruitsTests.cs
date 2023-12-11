using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        Dictionary<string, int> input = new()
        {
            ["apple"] = 2
        };

        int result = Fruits.GetFruitQuantity(input, "apple");

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        Dictionary<string, int> input = new()
        {
            ["apple"] = 2
        };

        int result = Fruits.GetFruitQuantity(input, "banana");

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        Dictionary<string, int> input = new();

        int result = Fruits.GetFruitQuantity(input, "banana");

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        Dictionary<string, int>? input = null;
        int result = Fruits.GetFruitQuantity(input, "banana");

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        Dictionary<string, int> input = new()
        {
            ["apple"] = 2
        };

        int result = Fruits.GetFruitQuantity(input, null);

        Assert.That(result, Is.EqualTo(0));
    }
}
