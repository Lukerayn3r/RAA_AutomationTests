using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace RAA_AutomationTests
{
    public class SignInPage : BasePage
    {
        By SignInLocator = By.ClassName("button");

        public void clickSignInLocator()
        {
            click(SignInLocator);
        }
    }
}
