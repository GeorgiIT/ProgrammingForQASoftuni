using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    //Equivalence Partitioning
    [TestCase(2.5, "Fail")]
    [TestCase(3.3, "Average")]
    [TestCase(3.6, "Good")]
    [TestCase(4.3, "Very Good")]
    [TestCase(4.7, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);
        

        // Assert
        Assert.AreEqual(expected, actual);
    }

    //Boundary Value Analysis
    [TestCase(2.0, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.0, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.5, "Good")]
    [TestCase(3.99, "Good")]
    [TestCase(4.00, "Very Good")]
    [TestCase(4.49, "Very Good")]
    [TestCase(4.5, "Excellent")]
    [TestCase(5, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
