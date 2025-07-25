using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Hooks
{
    [Binding]
    public class AutomationHooks
    {
        public  IWebDriver driver;

        [BeforeScenario]
        public void SetupScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [AfterScenario]
        public void TeardownScenario()
        {
            if (driver != null)
            {
                driver.Dispose();
            }

        }
    }
}