using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StudentRegistryApp.PageObjectModel;

namespace StudentRegistryApp.Tests
{
    public class Tests
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test_HomePage_TitleAndHeading()
        {
            var HomePage = new HomePage(driver);
            HomePage.Open();
            HomePage.LinkHomePage.Click();

            Assert.That(driver.Title, Is.EqualTo("MVC Example"));
            Assert.That(HomePage.GetPageHeading, Is.EqualTo("Students Registry"));
        }
        [Test]
        public void Test_HomePage_Links()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.LinkHomePage.Click();
            Assert.That(new HomePage(driver).isOpen());
            Assert.That(homePage.GetPageHeading, Is.EqualTo("Students Registry"));

            homePage.Open();
            homePage.AddStudentsPage.Click();

            Assert.That(new AddStudentPage(driver).isOpen());
            Assert.That(homePage.GetPageHeading, Is.EqualTo("Register New Student"));

            homePage.Open();
            homePage.ViewStudentsPage.Click();

            Assert.That(new ViewStudentsPage(driver).isOpen());
            Assert.That(homePage.GetPageHeading, Is.EqualTo("Registered Students"));

        }

        [OneTimeTearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}