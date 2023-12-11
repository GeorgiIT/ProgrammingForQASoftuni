using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        string title = "New Task Added";
        DateTime dueDate = DateTime.Now;
        _toDoList.AddTask(title, dueDate);

        string result = this._toDoList.DisplayTasks();

        Assert.That(result, Is.EqualTo($"To-Do List:{Environment.NewLine}[ ] New Task Added - Due: 12-11-2023"));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "New Task Added";
        DateTime dueDate = DateTime.Now;

        // Act
        _toDoList.AddTask(title, dueDate);
        _toDoList.CompleteTask(title);

        // Assert
        string result = _toDoList.DisplayTasks();
        Assert.IsTrue(result.Contains($"[✓] {title} - Due: {dueDate.ToString("MM/dd/yyyy")}"));

    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {

        string nonExistentTitle = "Nonexistent Task";

        Assert.That(() => _toDoList.CompleteTask(nonExistentTitle), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Act
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo("To-Do List:"));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string title = "New Task Added";
        DateTime dueDate = DateTime.Now;

        // Act
        _toDoList.AddTask(title, dueDate);
        title = "Next Task";  
        _toDoList.AddTask(title, dueDate);
        _toDoList.CompleteTask(title);


        // Assert
        string result = _toDoList.DisplayTasks();
        string expected = $"To-Do List:{Environment.NewLine}[ ] New Task Added - Due: 12-11-2023{Environment.NewLine}[✓] Next Task - Due: 12-11-2023";
        Assert.That(result, Is.EqualTo(expected));
    }
}
