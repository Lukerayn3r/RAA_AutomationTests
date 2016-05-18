using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RAA_AutomationTests;
using NUnit.Framework;

namespace RAA_AutomationTests.Pages
{
    class RecruitmentHomePage : BasePage
    {
        private By CreateNewVac = By.Id("new-vacancy-button");

        public void VerifyRecruitPage()
        {
            Assert.True(isDisplayed(CreateNewVac));
        }

        public void ClickCreateNewVac()
        {
            click(CreateNewVac);
        }
    }
}
