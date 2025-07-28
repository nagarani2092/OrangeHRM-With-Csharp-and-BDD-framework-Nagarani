
using EmployeeManagementBDD.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V136.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Pages
{
    public class AddEmployeePage : WebDriverKeywords
    {
        private By firstNameLocator = By.Name("firstName");
        private By middleNameLocator = By.Name("middleName");
        private By lastNameLocator = By.Name("lastName");
        private By saveLocator = By.XPath("//button[normalize-space()='Save']");
        private IWebDriver _driver;

        public AddEmployeePage(AutomationHooks hooks) : base(hooks.driver)
        {
            this._driver =hooks. driver;
        }
        public void FillEmployeeDetails(string firstName,string middleName,string lastName)
        {
            SetTextToElement(firstNameLocator, firstName);
            SetTextToElement(middleNameLocator, middleName);
            SetTextToElement(lastNameLocator, lastName);
        }
        public void ClickOnSave()
        {
            ClickOnElement(saveLocator);
        }
    }
}