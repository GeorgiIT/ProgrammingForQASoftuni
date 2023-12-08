using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dic1 = new();
        Dictionary<string, int> dic2 = new();

        CollectionAssert.IsEmpty(DictionaryIntersection.Intersect(dic1, dic2));
        
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dic1 = new() { ["Georgi"] = 25 };
        Dictionary<string, int> dic2 = new();

        CollectionAssert.IsEmpty(DictionaryIntersection.Intersect(dic1, dic2));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dic1 = new() { ["Georgi"] = 25 };
        Dictionary<string, int> dic2 = new() { ["Qna"] = 55 };

        CollectionAssert.IsEmpty(DictionaryIntersection.Intersect(dic1, dic2));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        Dictionary<string, int> dic1 = new() { ["Georgi"] = 25 };
        Dictionary<string, int> dic2 = new() { ["Georgi"] = 25 };

        Dictionary<string, int> result = DictionaryIntersection.Intersect(dic1, dic2);
        CollectionAssert.AreEqual(result, dic1);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dic1 = new() { ["Georgi"] = 25 };
        Dictionary<string, int> dic2 = new() { ["Georgi"] = 55 };

        CollectionAssert.IsEmpty(DictionaryIntersection.Intersect(dic1, dic2));
    }
}
