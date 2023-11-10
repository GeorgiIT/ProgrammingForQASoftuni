using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        List<string> expected = new List<string>();
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert

        CollectionAssert.AreEqual(expected, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "NoURLHere";

        List<string> expected = new List<string>();
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "OneUrl:https://www.softuni.com/"; // have error with input https://www.softuni.com/georgi386 input 

        List<string> expected = new List<string> { "https://www.softuni.com" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        string text = "MultipleUrls:https://www.softuni.com,https://www.google.com"; // have error with input https://www.softuni.com/georgi386 input 

        List<string> expected = new List<string> { "https://www.softuni.com", "https://www.google.com" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        string text = "MultipleUrls:?https://www.softuni.com?,?https://www.google.com?"; // have error with input https://www.softuni.com/georgi386 input 

        List<string> expected = new List<string> { "https://www.softuni.com?", "https://www.google.com?" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert

        CollectionAssert.AreEqual(expected, result);
    }
}
