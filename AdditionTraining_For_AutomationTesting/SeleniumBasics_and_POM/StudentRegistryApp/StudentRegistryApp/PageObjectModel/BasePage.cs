using OpenQA.Selenium;

namespace StudentRegistryApp.PageObjectModel
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        public virtual string PageUrl { get; }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public IWebElement LinkHomePage =>
            driver.FindElement(By.CssSelector("body > a:nth-child(1)"));

        public IWebElement ViewStudentsPage =>
            driver.FindElement(By.CssSelector("body > a:nth-child(3)"));

        public IWebElement AddStudentPage =>
            driver.FindElement(By.CssSelector("body > a:nth-child(5)"));

        public IWebElement PageHeadingText =>
            driver.FindElement(By.CssSelector("body > h1"));

        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool isOpen() 
        {
            return driver.Url == this.PageUrl;
        }
        public string GetPageTitle()
        {
            return driver.Title;
        }
        public string GetPageHeading()
        {
            return PageHeadingText.Text;
        }

    }
}
