using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        string path = null;

        

        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));

    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        string path = "";

        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        string path = @"c:\some\folder\somewhere.cs";

        string result = ExtractFile.GetFile(path);

        string expected = "File name: somewhere\nFile extension: cs";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        string path = @"c:\some\folder\somewhere";

        string result = ExtractFile.GetFile(path);

        string expected = "File name: somewhere";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        string path = @"c:\s0@me\fol$der\somewhere.cs";

        string result = ExtractFile.GetFile(path);

        string expected = "File name: somewhere\nFile extension: cs";
        Assert.That(result, Is.EqualTo(expected));
    }
}
