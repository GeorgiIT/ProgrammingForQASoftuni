using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistryApp.PageObjectModel
{
    public class AddStudentPage : BasePage
    {

        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl =>
            "https://mvc-app-node-express--georgitodorov4.repl.co/add-student";
            
    }
}
