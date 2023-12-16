using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace StudentRegistryApp.PageObjectModel
{
    public class ViewStudentsPage : BasePage
    {

        public ViewStudentsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl =>
            "https://mvc-app-node-express--georgitodorov4.repl.co/students";

        public ReadOnlyCollection<IWebElement> ListItemsStudents =>
            driver.FindElements(By.CssSelector("body > ul > li"));

        public string[] GetRegisteredStudents()
        {
            var elementsStudents = this.ListItemsStudents.Select(s => s.Text).ToArray();
            return elementsStudents;
        }

    }
}
