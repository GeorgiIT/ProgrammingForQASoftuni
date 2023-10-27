using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        long n = 1;

        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long n = 7;

        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Is.EqualTo(7));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long n = 997;

        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Is.EqualTo(997));
    }
}
