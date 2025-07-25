
using EmployeeManagementBDD.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Pages
{
    /// <summary>
    /// This class handles all menu and also handles all common elements of the application
    /// </summary>
    public class MainPage : WebDriverKeywords
    {
        private By _pimMenuLocator = By.XPath("//span[text()='PIM']");
        private IWebDriver _driver;

        public MainPage(AutomationHooks hooks) : base(hooks.driver)
        {
            this._driver = hooks.driver;
        }
        public void ClickOnPIMMenu()
        {
            ClickOnElement(_pimMenuLocator);
        }
    }
}