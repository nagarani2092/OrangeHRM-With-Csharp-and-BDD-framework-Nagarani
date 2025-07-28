
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Hooks
{
    public class WebDriverKeywords
    {
        private IWebDriver _driver;
        private DefaultWait<IWebDriver> _wait;

       // public static object ScreenshotImageFormat { get; private set; }

        public WebDriverKeywords(IWebDriver driver)
        {
            this._driver = driver;
            SetupFluentWait();
        }
        public void SetupFluentWait(int timeout = 30000, int pollingTimeout = 500)
        {
            _wait = new DefaultWait<IWebDriver>(_driver);
            _wait.PollingInterval = TimeSpan.FromMilliseconds(pollingTimeout);
            _wait.Timeout = TimeSpan.FromMilliseconds(timeout);
            _wait.IgnoreExceptionTypes(typeof(Exception));
        }
        public void ClickOnElement(By locator)
        {
            //_driver.FindElement(locator).Click();
            _wait.Until(x => x.FindElement(locator)).Click();
        }

        public void SetTextToElement(By locator, string text)
        {
            _driver.FindElement(locator).SendKeys(text);
        }

        public string GetTextFromElement(By locator)
        {
            return _driver.FindElement(locator).Text;
        }

        public string GetAtrributeValueOfElement(By locator, string attributeName)
        {
            return _driver.FindElement(locator).GetAttribute(attributeName);
        }

        public void SwitchTabByTitle(string title)
        {
            foreach (var sessionId in _driver.WindowHandles)
            {
                _driver.SwitchTo().Window(sessionId);
                if (_driver.Title.Equals(title))
                {
                    break;
                }
            }

        }

        public void SetTextToElementWithRetry(By locator, string text, int timeout = 30000, int pollingTimeout = 500)
        {
            SetupFluentWait(timeout, pollingTimeout);
            _wait.Until(x => x.FindElement(locator)).SendKeys(text);
        }
        public void ClickOnElementWithRetry(By locator)
        {
            _wait.Until(x => x.FindElement(locator)).Click();
        }

        public static void TakeScreenshot(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string fileName = Path.Combine(path, "screenshot_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png");
            ss.SaveAsFile(fileName);



        }

        }
    }
