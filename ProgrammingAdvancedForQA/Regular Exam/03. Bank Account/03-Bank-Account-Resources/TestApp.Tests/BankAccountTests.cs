using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    public BankAccount _bankAccount;
    [SetUp]
    public void Setup()
    {
        this._bankAccount = new BankAccount(100);
    }


    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        this._bankAccount = new BankAccount(100.00);
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        this._bankAccount.Deposit(10);

        double balance = this._bankAccount.Balance;
        double expectedBalance = 110.00;
        Assert.That(balance, Is.EqualTo(expectedBalance));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => this._bankAccount.Deposit(-10));
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        this._bankAccount.Withdraw(10.00);
        double expectedBalance = 90.00;
        double balance = this._bankAccount.Balance;
        Assert.That(balance, Is.EqualTo(expectedBalance));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => this._bankAccount.Withdraw(-10));
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => this._bankAccount.Withdraw(110));
    }
}
