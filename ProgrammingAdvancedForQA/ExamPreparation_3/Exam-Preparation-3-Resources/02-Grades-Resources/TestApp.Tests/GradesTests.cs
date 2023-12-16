using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        Dictionary<string, int> dataGrades = new()
        {
            ["Georgi"] = 5,
            ["Plamen"] = 3,
            ["Kamen"] = 2,
            ["Ivan"] = 6,
            ["Ivailo"] = 2,
            ["Anton"] = 4,
        };
        string result = Grades.GetBestStudents(dataGrades);
        string expectedResult = $"Ivan with average grade 6.00{Environment.NewLine}Georgi with average grade 5.00{Environment.NewLine}Anton with average grade 4.00";

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        Dictionary<string, int> dataGrades = new()
        {
            
        };
        string result = Grades.GetBestStudents(dataGrades);
        string expectedResult = $"";

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        Dictionary<string, int> dataGrades = new()
        {
            ["Georgi"] = 5,
            ["Anton"] = 4,
        };
        string result = Grades.GetBestStudents(dataGrades);
        string expectedResult = $"Georgi with average grade 5.00{Environment.NewLine}Anton with average grade 4.00";

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        Dictionary<string, int> dataGrades = new()
        {
            ["Georgi"] = 5,
            ["Plamen"] = 3,
            ["Kamen"] = 2,
            ["Ivan"] = 5,
            ["Ivailo"] = 2,
            ["Anton"] = 5,
        };
        string result = Grades.GetBestStudents(dataGrades);
        string expectedResult = $"Anton with average grade 5.00{Environment.NewLine}Georgi with average grade 5.00{Environment.NewLine}Ivan with average grade 5.00";

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
