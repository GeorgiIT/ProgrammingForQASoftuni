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
            ["Anton"] = 3,
        };
        string result = Grades.GetBestStudents(dataGrades);
        string expectedResult = $"{dataGrades.Keys} with grade {dataGrades.Values}";

        foreach (var item in dataGrades) 
        {
            Assert.That
        }
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // TODO: finish the test
    }
}
