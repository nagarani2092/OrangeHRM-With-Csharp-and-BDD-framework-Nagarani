using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
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
        private static BrowserSettings BrowserSettings {  get; set; }

        [BeforeTestRun]
        public static void Init()
        {
            InitConfigScript();
        }

        [BeforeScenario]
        public void SetupScenario()
        {
            InitConfigScript();

            if (BrowserSettings.BrowserName.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            else if (BrowserSettings.BrowserName.ToLower().Equals("ff"))
            {
                driver = new FirefoxDriver();
            }
            else 
            {
                ChromeOptions options = new ChromeOptions();
                if (BrowserSettings.Headless == true)
                {
                    options.AddArguments("--headless");
                }
                driver = new ChromeDriver(options);
            }



            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public  static void InitConfigScript()
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json").Build();
            BrowserSettings = config.GetSection("BrowserSettings").Get<BrowserSettings>();
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