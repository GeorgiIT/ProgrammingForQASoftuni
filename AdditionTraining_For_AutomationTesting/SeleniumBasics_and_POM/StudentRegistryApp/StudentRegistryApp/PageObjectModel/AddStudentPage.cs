using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace StudentRegistryApp.PageObjectModel
{
    public class AddStudentPage : BasePage
    {

        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl =>
            "https://mvc-app-node-express--georgitodorov4.repl.co/add-student";

        public IWebElement InputField =>
            driver.FindElement(By.Id("name"));
        
        public IWebElement EmailField =>
            driver.FindElement(By.Id("email"));

        public IWebElement AddButton =>
            driver.FindElement(By.CssSelector("body > form > button"));

        public IWebElement ErrorMsg =>
            driver.FindElement(By.XPath("//div[contains(@style,'background:red')]"));

        public void AddStudent(string name, string email)
        {
            InputField.SendKeys(name);
            EmailField.SendKeys(email);
            AddButton.Click();
        }

    }
}
