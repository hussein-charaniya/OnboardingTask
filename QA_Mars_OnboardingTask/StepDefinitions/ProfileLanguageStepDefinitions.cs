using QA_Mars_OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using QA_Mars_OnboardingTask.Pages;


namespace QA_Mars_OnboardingTask.StepDefinitions
{
    [Binding]
    public class ProfileLanguageStepDefinitions : CommonDriver
    {
        // Initializing page objects

        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ProfileSkillPage profileSkillPageObj = new ProfileSkillPage();

        [Given(@"Login to the portal successfully")]
        public void GivenLoginToThePortalSuccessfully()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // login page object initialization and definition.
            //LoginPage loginPageObj = new LoginPage();
            LoginPage.LoginSteps(driver);
        }

        [Given(@"Navigate to language via profile tab")]
        public void GivenNavigateToLanguageViaProfileTab()
        {

            // Home page object initialization and definition.
            // HomePage homePageObj = new HomePage();
            homePageObj.GoToHomePage(driver);
        }

        [When(@"Add a New language in profile")]
        public void WhenAddANewLanguageInProfile()
        {
            // Profile skill page object initialization and definition.
            //ProfileSkillPage profileSkillPageObj = new ProfileSkillPage();
            profileSkillPageObj.AddSkill(driver);
        }

        [Then(@"Profile skill was successfully created")]
        public void ThenProfileSkillWasSuccessfullyCreated()
        {
            throw new PendingStepException();
        }
    }
}
