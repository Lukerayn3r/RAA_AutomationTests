using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace RAA_AutomationTests.Resources
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver driver;

        [BeforeScenario()]
        private void startBrowser()
        {
            driver = new FirefoxDriver();
            var baseUrl = ConfigurationManager.AppSettings["service.url"];
            driver.Navigate().GoToUrl(baseUrl);
        }

        public IWebDriver getDriver()
        {
            return driver;
        }
    }
}
