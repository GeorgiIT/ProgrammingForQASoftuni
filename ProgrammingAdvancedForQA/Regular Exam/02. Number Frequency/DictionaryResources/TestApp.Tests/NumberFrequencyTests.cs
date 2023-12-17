using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
        };
        
        Dictionary<int,int> result = NumberFrequency.CountDigits(0);

        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [1] = 1,
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(1);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [1] = 3,
            [2] = 2,
            [3] = 1,
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(111223);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            { 1, 1 },  
            { 2, 1 },  
            { 3, 1 },  
            { 4, 1 },  
            { 5, 1 }   
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(-12345);

        CollectionAssert.AreEqual(expected, result);
    }
}
