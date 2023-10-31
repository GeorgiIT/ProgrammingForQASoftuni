using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        double x1 = 1;
        double x2 = 2;
        double y1 = 1;
        double y2 = 2;

        string resulst = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That("(1, 1)", Is.EqualTo(resulst));

    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        double x1 = 5;
        double x2 = 2;
        double y1 = 3;
        double y2 = 2;

        string resulst = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That("(2, 2)", Is.EqualTo(resulst));

    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        double x1 = 5;
        double x2 = 5;
        double y1 = 5;
        double y2 = 5;

        string resulst = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That("(5, 5)", Is.EqualTo(resulst));
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint() // Bad name
    {
        double x1 = -2;
        double x2 = 2;
        double y1 = -1;
        double y2 = 1;

        string resulst = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That("(-2, -1)", Is.EqualTo(resulst));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint() // Bad name
    {
        double x1 = 3;
        double x2 = -5;
        double y1 = 3;
        double y2 = -2;

        string resulst = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That("(-5, -2)", Is.EqualTo(resulst));
    }
}
