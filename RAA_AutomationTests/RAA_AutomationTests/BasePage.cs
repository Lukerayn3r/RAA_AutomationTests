using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace RAA_AutomationTests
{
    using OpenQA.Selenium.Firefox;
    using Resources;

    public class BasePage
    {
        protected static IWebDriver driver;

        protected BasePage()
        {
            Hooks h = new Hooks();
            //cant keep creating a new driver need to change this
            driver = h.getDriver();
        }

        public void click(By locator)
        {
            Find(locator).Click();
        }

        public void type(string inputText, By locator)
        {
            Find(locator).SendKeys(inputText);
        }

        public IWebElement Find(By locator)
        {
            //ValidateSelector(locator); will update css selectors, however not to cause any extra delays by checking this programmatically.

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));

            return driver.FindElement(locator);
        }

        public bool isDisplayed(By locator)
        {
            try
            {
                var element = Find(locator);
                return ElementIsDisplayed(element);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("That element does not exist on this page");
                return false;
            }
        }

        public static bool ElementIsDisplayed(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public void Sleep(int milliseconds) /// conditional wait is now added at WebElement level
        {
            Console.WriteLine("****** TODO wait for an element instead -> Slept for " + milliseconds + "ms");
            Thread.Sleep(milliseconds);
        }
    }
}
