
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
        private string _profileNameXpath = "//h6[contains(normalize-space(), '@@@@@')]";
        private IWebDriver _driver;

        public PersonalDetailsPage(AutomationHooks hooks) : base(hooks.driver)
        {
            this._driver = hooks. driver;
        }
        public string GetProfileName(string profileName)
        {
           return GetTextFromElement(By.XPath(_profileNameXpath.Replace("@@@@@", profileName)));
        }
    }
}