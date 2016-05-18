using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RAA_AutomationTests.Pages
{
    public class SignInPortal : BasePage
    {
        By AzureLocator = By.Name("Test (Azure AD)");

        public void clickAzureLocator()
        {
            click(AzureLocator);
        }
    }
}
