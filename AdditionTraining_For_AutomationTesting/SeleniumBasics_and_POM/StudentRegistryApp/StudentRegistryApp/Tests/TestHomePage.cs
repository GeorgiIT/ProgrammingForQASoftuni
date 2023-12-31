using NUnit.Framework;
using StudentRegistryApp.PageObjectModel;

namespace StudentRegistryApp.Tests
{
    public class TestHomePage : BaseTest
    {

        [Test]
        public void Test_HomePage_TitleAndHeading()
        {
            var page = new HomePage(driver);
            page.Open();
            page.LinkHomePage.Click();

            Assert.That(driver.Title, Is.EqualTo("MVC Example"));
            Assert.That(page.GetPageHeading, Is.EqualTo("Students Registry"));
        }
        [Test]
        public void Test_HomePage_Links()
        {
            var page = new HomePage(driver);
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