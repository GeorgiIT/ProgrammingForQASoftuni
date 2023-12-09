using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        string productName = "Coca cola";
        double productPrice = 2.50;
        int quantity = 1;

        // Act
        this._inventory.AddProduct(productName, productPrice, quantity);
        string result = this._inventory.DisplayInventory();


        // Assert
        Assert.That(result, Is.EqualTo($"Product Inventory:{Environment.NewLine}Coca cola - Price: $2.50 - Quantity: 1"));

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Act      
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo("Product Inventory:"));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        string productName = "Coca cola";
        double productPrice = 2.50;
        int quantity = 1;

        // Act
        this._inventory.AddProduct(productName, productPrice, quantity);

        productName = "Bread";
        productPrice = 1.10;
        quantity = 2;

        this._inventory.AddProduct(productName, productPrice, quantity);

        string result = this._inventory.DisplayInventory();


        // Assert
        Assert.That(result, Is.EqualTo($"Product Inventory:{Environment.NewLine}Coca cola - Price: $2.50 - Quantity: 1{Environment.NewLine}Bread - Price: $1.10 - Quantity: 2"));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        double result = this._inventory.CalculateTotalValue();

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        string productName = "Coca cola";
        double productPrice = 2.50;
        int quantity = 1;

        // Act
        this._inventory.AddProduct(productName, productPrice, quantity);

        productName = "Bread";
        productPrice = 1.10;
        quantity = 2;

        this._inventory.AddProduct(productName, productPrice, quantity);

        double result = this._inventory.CalculateTotalValue();


        // Assert
        Assert.That(result, Is.EqualTo(4.70));
    }
}
