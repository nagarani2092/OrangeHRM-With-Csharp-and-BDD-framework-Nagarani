using EmployeeManagementBDD.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Pages
{
    public class DashboardPage : WebDriverKeywords
    {
        private By _timeAtWorkLocator = By.XPath("//p[contains(normalize-space(),'Work')]");
        private IWebDriver _driver;

        public DashboardPage(AutomationHooks hooks) : base(hooks.driver)
        {
            this._driver = hooks.driver;
        }

        public string GetTimeAtWorkHeader()
        {
            return _driver.FindElement(_timeAtWorkLocator).Text;
        }
    }
}