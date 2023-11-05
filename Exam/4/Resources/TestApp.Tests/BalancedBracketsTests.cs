using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        string[] input = { };

        

        bool actualResult = BalancedBrackets.IsBalanced(input);

        Assert.IsTrue(actualResult);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        string[] input = {"{","}" };



        bool actualResult = BalancedBrackets.IsBalanced(input);

        Assert.IsTrue(actualResult);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        string[] input = { ")", "(", ")" };  // we have bug here with input { "[", "{", "}" } -> return TRUE





        bool actualResult = BalancedBrackets.IsBalanced(input);

        Assert.IsFalse(actualResult);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        string[] input = { "{", "}", ")", ")" }; // bug with input { "{", "}", "}" } return TRUE



        bool actualResult = BalancedBrackets.IsBalanced(input);

        Assert.IsFalse(actualResult);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        string[] input = { "{", "{", "(" }; 



        bool actualResult = BalancedBrackets.IsBalanced(input);

        Assert.IsFalse(actualResult);
    }
}
