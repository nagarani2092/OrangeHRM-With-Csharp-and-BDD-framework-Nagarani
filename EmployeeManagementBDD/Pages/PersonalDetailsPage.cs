
using EmployeeManagementBDD.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Pages
{
    public class PersonalDetailsPage : WebDriverKeywords
    {
        private IWebDriver _driver;

        public PersonalDetailsPage(AutomationHooks hooks) : base(hooks.driver)
        {
            this._driver = hooks. driver;
        }
    }
}