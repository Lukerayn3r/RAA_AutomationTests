using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using RAA_AutomationTests.Pages;

namespace RAA_AutomationTests
{
    [Binding]
    public class SigningInSteps
    {
        private readonly SignInPage _signPage;
        private readonly SignInPortal _signPortal;
        private readonly AzureSignInPage _azureSignIn;
        private readonly RecruitmentHomePage _recruitHome;

        public SigningInSteps()
        {
            _signPage = new SignInPage();
            _signPortal = new SignInPortal();
            _azureSignIn = new AzureSignInPage();
            _recruitHome = new RecruitmentHomePage();
        }


        [Given(@"I am on the ""(.*)""")]
        public void GivenIAmOnThe(string signInPage)
        {
            //etc
        }
        
        [When(@"I click sign in")]
        public void WhenIClickSignIn()
        {
            _signPage.clickSignInLocator();
        }
        
        [When(@"choose the azure portal")]
        public void WhenChooseTheAzurePortal()
        {
            _signPortal.clickAzureLocator();
        }
        
        [When(@"enter my credentials")]
        public void WhenEnterMyCredentials()
        {
            _azureSignIn.EnterEmailPass("test.one@naspread.onmicrosoft.com", "Windmill3");
        }
        
        [Then(@"I should be on the ""(.*)""")]
        public void ThenIShouldBeOnThe(string homePage)
        {
            _recruitHome.VerifyRecruitPage();
        }
    }
}
