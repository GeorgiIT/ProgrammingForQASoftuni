using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistryApp.PageObjectModel
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl =>
            "https://mvc-app-node-express--georgitodorov4.repl.co/";

        public IWebElement ElementStudentCount =>
            driver.FindElement(By.CssSelector("body > p > b"));

        public int GetStudentsCount()
        {
            string studentCountText = this.ElementStudentCount.Text;
            return int.Parse(studentCountText);
        }
            
    }
}
