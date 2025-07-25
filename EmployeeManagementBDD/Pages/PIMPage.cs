
using EmployeeManagementBDD.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Pages
{
    
    public class PIMPage : WebDriverKeywords
    {
        private By _addEmployeeLocator = By.LinkText("Add Employee");
        private IWebDriver _driver;

        public PIMPage(AutomationHooks hooks) : base(hooks.driver)
        {
            this._driver = hooks.driver;
        }
        public void ClickOnAddEmployee()
        {
            base.ClickOnElement(_addEmployeeLocator);
        }
    }
}