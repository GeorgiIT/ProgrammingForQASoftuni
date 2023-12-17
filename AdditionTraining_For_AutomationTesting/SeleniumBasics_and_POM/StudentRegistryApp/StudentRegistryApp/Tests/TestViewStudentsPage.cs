using NUnit.Framework;
using StudentRegistryApp.PageObjectModel;

namespace StudentRegistryApp.Tests
{
    public class TestViewStudentPage : BaseTest
    {
        
        [Test]
        public void Test_ViewStudentsPage_TitleAndHeading()
        {
            var page = new ViewStudentsPage(driver);
            page.Open();
            page.ViewStudentsPage.Click();

            Assert.That(driver.Title, Is.EqualTo("Students"));
            Assert.That(page.GetPageHeading, Is.EqualTo("Registered Students"));
            var students = page.GetRegisteredStudents();

            foreach (var student in students)
            {
                Assert.IsTrue(student.IndexOf("(") > 0);
                Assert.IsTrue(student.LastIndexOf(")") == student.Length - 1);
            }

        }
        [Test]
        public void Test_ViewStudentsPage_Links()
        {
            var page = new ViewStudentsPage(driver);
            page.Open();
            page.LinkHomePage.Click();
            Assert.That(new HomePage(driver).isOpen());
            Assert.That(page.GetPageHeading, Is.EqualTo("Students Registry"));

            page.Open();
            page.AddStudentPage.Click();

            Assert.That(new AddStudentPage(driver).isOpen());
            Assert.That(page.GetPageHeading, Is.EqualTo("Register New Student"));

            page.Open();
            page.ViewStudentsPage.Click();

            Assert.That(new ViewStudentsPage(driver).isOpen());
            Assert.That(page.GetPageHeading, Is.EqualTo("Registered Students"));

        }


    }
}