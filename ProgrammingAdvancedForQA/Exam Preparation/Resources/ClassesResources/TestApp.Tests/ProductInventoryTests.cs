using NUnit.Framework;
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

        // Assert
        // Check if the product is in the inventory
        CollectionAssert.Contains(this._inventory.Products, new { Name = productName, Price = productPrice, Quantity = quantity });

        
        Assert.AreEqual(productPrice * quantity, this._inventory.CalculateTotalValue());

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // TODO: finish the test
    }
}
