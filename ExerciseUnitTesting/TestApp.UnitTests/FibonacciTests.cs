using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int n = 0;

        Assert.That(() => Fibonacci.CalculateFibonacci(n), Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int n = 10;

        Assert.That(() => Fibonacci.CalculateFibonacci(n), Is.EqualTo(55));
    }
}