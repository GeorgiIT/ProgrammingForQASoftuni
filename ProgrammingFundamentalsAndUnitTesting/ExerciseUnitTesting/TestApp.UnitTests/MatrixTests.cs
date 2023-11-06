using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatrixTests
{
    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 } };
        List<List<int>> expected = new() { new() { 6, 8 }, new() { 10, 12 } };

        // Act
        List<List<int>> actualResult = Matrix.MatrixAddition(matrixA, matrixB);
        // Assert
        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
    {
        // Arrange
        List<List<int>> matrixA = new();
        List<List<int>> matrixB = new();

        List<List<int>> expected = new();

        // Act
        List<List<int>> actualResult = Matrix.MatrixAddition(matrixA, matrixB);
        // Assert
        Assert.AreEqual(expected, actualResult);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_MatrixAddition_NegativeNumbers_ReturnsCorrectResult()
    {
        // TODO: finish test
    }

    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
    {
        // Arrange

        // Act
        //List<List<int>> result = Matrix.MatrixAddition(matrixA, matrix0);

        // Assert
        //Assert.That(result, Is.EqualTo(matrixA));
    }
}
