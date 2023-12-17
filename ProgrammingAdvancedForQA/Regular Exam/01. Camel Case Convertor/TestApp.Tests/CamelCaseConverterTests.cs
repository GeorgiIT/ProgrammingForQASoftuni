using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    

    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        string input = "";

        string result = CamelCaseConverter.ConvertToCamelCase(input);

        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        string input = "HELLO";

        string result = CamelCaseConverter.ConvertToCamelCase(input);


        Assert.That(result, Is.EqualTo("hello"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        string input = "hello world georgi";

        string result = CamelCaseConverter.ConvertToCamelCase(input);


        Assert.That(result, Is.EqualTo("helloWorldGeorgi"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        string input = "HeLlo WoRlD HeLLo WORLD";

        string result = CamelCaseConverter.ConvertToCamelCase(input);


        Assert.That(result, Is.EqualTo("helloWorldHelloWorld"));
    }
}
