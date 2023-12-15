using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistryApp.PageObjectModel
{
    public class ViewStudentsPage : BasePage
    {

        public ViewStudentsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl =>
            "https://mvc-app-node-express--georgitodorov4.repl.co/students";
            
    }
}
