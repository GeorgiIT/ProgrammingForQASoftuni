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
        List<string> commands = new List<string> {};
        decimal money = 10;


        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands), "Number did not parse correctly!");
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        List<int> initialQuality = new List<int> { 1, 2, 3 };
        List<string> commands = new List<string> { "incorrect command", "some wrong command" };
        decimal money = 10;


        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands), "Number did not parse correctly!");
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        List<int> initialQuality = new () { 1, 2, 3};
        List<string> commands = new() { "1", "2", "3",   "Hit it again, Gabsy!" };
        decimal money = 100;

        string result = DrumSet.Drum(money, initialQuality, commands);

        Assert.AreEqual(result, "1 2 3\nGabsy has 61.00lv.");
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        List<int> initialQuality = new List<int> { 3 };
        List<string> commands = new List<string> { "2","Hit it again, Gabsy!" };
        decimal money = 0;

        string result = DrumSet.Drum(money, initialQuality, commands);

        Assert.AreEqual(result, "1\nGabsy has 0.00lv.");
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        List<int> initialQuality = new List<int> { 3,4,5 };
        List<string> commands = new List<string> { "3","3", "Hit it again, Gabsy!" };
        decimal money = 5;

        string result = DrumSet.Drum(money, initialQuality, commands);

        Assert.AreEqual(result, "\nGabsy has 5.00lv.");
    }
}
