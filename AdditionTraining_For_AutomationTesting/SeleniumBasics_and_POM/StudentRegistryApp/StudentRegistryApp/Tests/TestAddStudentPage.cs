using NUnit.Framework;
using StudentRegistryApp.PageObjectModel;

namespace StudentRegistryApp.Tests
{
    public class TestAddStudentPage : BaseTest
    {
        [Test]
        public void Test_TestAddStudentPage_TitleAndHeading()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            page.AddStudentPage.Click();

            Assert.That(driver.Title, Is.EqualTo("Add Student"));
            Assert.That(page.GetPageHeading, Is.EqualTo("Register New Student"));
            Assert.That(page.InputField.Text, Is.Empty);
            Assert.That(page.EmailField.Text, Is.Empty);
            Assert.That(page.AddButton.Text, Is.EqualTo("Add"));
        }

        [Test]
        public void Test_TestAddStudentPage_AddValidStudent()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            page.AddStudentPage.Click();
            string name = "Gosho" + DateTime.Now.Ticks;
            string email = "georgi" + DateTime.Now.Ticks + "@gmail.com";
            page.AddStudent(name, email);

            var viewStudentPage = new ViewStudentsPage(driver);
            Assert.That(viewStudentPage.isOpen());

            var studentsRegistery = viewStudentPage.GetRegisteredStudents();
            var newStudent = name + " (" + email + ")";

            Assert.Contains(newStudent, studentsRegistery);
        }

        [Test]
        public void Test_TestAddStudentPage_AddInvalidStudent()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            page.AddStudentPage.Click();
            string name = "";
            string email = "georgi" + DateTime.Now.Ticks + "@gmail.com";
            page.AddStudent(name, email);

            var viewStudentPage = new ViewStudentsPage(driver);
            Assert.That(page.isOpen());
            Assert.IsTrue(page.ErrorMsg.Text.Contains("Cannot add student"));


        }

        [Test]
        public void Test_AddStudentPage_Links()
        {
            var page = new AddStudentPage(driver);
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