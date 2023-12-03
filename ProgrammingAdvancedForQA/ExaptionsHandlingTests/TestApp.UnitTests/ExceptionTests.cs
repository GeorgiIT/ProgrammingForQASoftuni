using Newtonsoft.Json.Linq;
using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Reflection;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = this._exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        decimal totalPrice = 100.0m;
        decimal discount = 10.0m;

        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        Assert.That(result, Is.EqualTo(90m));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = -10.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        int[] input = {1, 2, 3, 4, 5};
        int index = 3;

        int result = this._exceptions.IndexOutOfRangeGetElement(input, index);

        Assert.That(result , Is.EqualTo(4));

    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int index = -2;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 8;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        bool input = true;

        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(input), Is.EqualTo("User logged in."));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        bool input = false;

        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(input), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        string input = "52";

        int result = this._exceptions.FormatExceptionParseInt(input);

        Assert.That(result, Is.EqualTo(52));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        string input = "Hello22.";

        

        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        Dictionary<string, int> input = new()
        {
            ["one"] = 10,
            ["two"] = 20,
            ["three"] = 30
        };
        string key = "two";

        int result = this._exceptions.KeyNotFoundFindValueByKey(input, key);

        Assert.That(result, Is.EqualTo(20));

    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        Dictionary<string, int> input = new()
        {
            ["one"] = 10,
            ["two"] = 20,
            ["three"] = 30
        };
        string key = "second";

        

        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        int a = 10;
        int b = 20;

        int result = this._exceptions.OverflowAddNumbers(a, b);

        Assert.That(result, Is.EqualTo(30));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        var a = int.MaxValue;
        var b = 1;

        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        var a = int.MinValue;
        var b = -2;

        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        int divident = 10;
        int divisor = 2;

        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(divident, divisor), Is.EqualTo(5));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        int divident = 10;
        int divisor = 0;

        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(divident, divisor), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        int[] arr = {1, 2, 3, 4, 5};
        var index = 2;

        var result = this._exceptions.SumCollectionElements(arr, index);
        
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        int[] arr = null;
        var index = 2;

        Assert.That(() => this._exceptions.SumCollectionElements(arr, index), Throws.InstanceOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        var index = 12;

        Assert.That(() => this._exceptions.SumCollectionElements(arr, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        Dictionary<string, string> elements = new()
        {
            { "BG", "20" },
            { "UK", "30" }
        };
        string key = "BG";

        int result = this._exceptions.GetElementAsNumber(elements, key);

        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        Dictionary<string, string> elements = new()
        {
            { "BG", "20" },
            { "UK", "30" }
        };
        string key = "USA";

        Assert.That(() => this._exceptions.GetElementAsNumber(elements, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        Dictionary<string, string> elements = new()
        {
            { "BG", "20abv" },
            { "UK", "30" }
        };
        string key = "BG";

        Assert.That(() => this._exceptions.GetElementAsNumber(elements, key), Throws.InstanceOf<FormatException>());
    }
}
