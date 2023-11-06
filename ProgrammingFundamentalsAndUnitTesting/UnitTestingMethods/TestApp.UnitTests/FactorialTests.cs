using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        Factorial factorial = new();

        int actual = Factorial.CalculateFactorial(0);

        Assert.AreEqual(actual, 1);
    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        Factorial factorial = new();

        int actual = Factorial.CalculateFactorial(5);

        Assert.AreEqual(actual, 120);
    }

    [Test]
    public void CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        Factorial factorial = new();

        
    }
}
