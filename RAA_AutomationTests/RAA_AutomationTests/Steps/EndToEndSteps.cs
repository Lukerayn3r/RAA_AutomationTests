using System;
using TechTalk.SpecFlow;
using RAA_AutomationTests.Pages;

namespace RAA_AutomationTests
{
    [Binding]
    public class EndToEndSteps
    {
        private readonly RecruitmentHomePage _recruitHome;
        private readonly SelectEmployerPage _selectEmployer;

        public EndToEndSteps()
        {
            _recruitHome = new RecruitmentHomePage();
            _selectEmployer = new SelectEmployerPage();
        }

        [When(@"I create a new vacancy")]
        public void WhenICreateANewVacancy()
        {
            _recruitHome.ClickCreateNewVac();
            _selectEmployer.ClickSelectEmployer();
        }
    }
}
