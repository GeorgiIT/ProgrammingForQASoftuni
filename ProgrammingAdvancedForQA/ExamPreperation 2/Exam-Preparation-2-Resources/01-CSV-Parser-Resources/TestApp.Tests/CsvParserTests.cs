using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        string input = string.Empty;

        string[] result = CsvParser.ParseCsv(input);
        //string expectedResult = string.Empty;
        // TODO: finish the test

        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        string input = "1";

        string[] result = CsvParser.ParseCsv(input);
        string[] expectedResult = { "1" };
        // TODO: finish the test

        CollectionAssert.AreEqual(result, expectedResult);
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        string input = "1,2,3,4,5";

        string[] result = CsvParser.ParseCsv(input);
        string[] expectedResult = { "1", "2", "3", "4", "5" };
        // TODO: finish the test

        CollectionAssert.AreEqual(result, expectedResult);
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        string input = "1 ,2,3, 4, 5  ";

        string[] result = CsvParser.ParseCsv(input);
        string[] expectedResult = { "1", "2", "3", "4", "5" };
        // TODO: finish the test

        CollectionAssert.AreEqual(result, expectedResult);
    }
}
