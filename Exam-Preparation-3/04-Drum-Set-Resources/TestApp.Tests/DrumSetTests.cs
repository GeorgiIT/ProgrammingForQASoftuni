using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        List<int> initialQuality = new List<int> {1, 2, 3};
        List<string> commands = new List<string> {"incorrect command" };
        decimal money = 10;


        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands));
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        List<int> initialQuality = new List<int> { 1, 2, 3 };
        List<string> commands = new List<string> { "incorrect command" };
        decimal money = 10;


        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands));
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        // TODO: implement the test
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        // TODO: implement the test
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        // TODO: implement the test
    }
}
