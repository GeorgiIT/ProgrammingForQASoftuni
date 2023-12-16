using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        string input = "Hello";
        string start = "e";
        string end = "o";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(result, Is.EqualTo("ll"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        string input = "Hello";
        string start = "n";
        string end = "o";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        string input = "Hello";
        string start = "H";
        string end = "v";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        string input = "Hello";
        string start = "n";
        string end = "v";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        string input = "";
        string start = "n";
        string end = "o";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        string input = "Hello";
        string start = "el";
        string end = "ll";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(result, Is.EqualTo("Substring not found"));
    }
}
