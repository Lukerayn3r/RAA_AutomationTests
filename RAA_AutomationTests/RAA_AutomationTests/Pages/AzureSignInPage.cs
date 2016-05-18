using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RAA_AutomationTests.Pages
{
    class AzureSignInPage : BasePage
    {
        private By EmailLocator = By.Id("cred_userid_inputtext");
        private By PasswordLocator = By.Id("cred_password_inputtext");
        private By SignInLocator = By.Id("cred_sign_in_button");

        public void EnterEmailPass(string Username, string Password)
        {
            type(Username, EmailLocator);
            type(Password, PasswordLocator);
            Sleep(4000);
            click(SignInLocator);
            //Sleep(20000);
        }
    }
}
