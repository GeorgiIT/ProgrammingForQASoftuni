using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IWebElement AddStudentsPage =>
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
