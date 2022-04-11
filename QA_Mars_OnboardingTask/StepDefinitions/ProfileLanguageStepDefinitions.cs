using OpenQA.Selenium.Chrome;
using QA_Mars_OnboardingTask.Pages;
using QA_Mars_OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace QA_Mars_OnboardingTask.StepDefinitions
{
    [Binding]
    public class ProfileLanguageStepDefinitions : CommonDriver
    {
        // Initializing page objects

        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ProfileSkillPage profileSkillPageObj = new ProfileSkillPage();

        [Given(@"Login to th portal successfully")]
        public void GivenLoginToThPortalSuccessfully()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // login page object initialization and definition.
            //LoginPage loginPageObj = new LoginPage();
            LoginPage.LoginSteps(driver);
        }

        [Given(@"Navigate to The language via profile tab")]
        public void GivenNavigateToTheLanguageViaProfileTab()
        {
            // Home page object initialization and definition.
            // HomePage homePageObj = new HomePage();
            homePageObj.GoToHomePage(driver);
        }

        [When(@"Add a New language in the profile")]
        public void WhenAddANewLanguageInTheProfile()
        {
            // Profile skill page object initialization and definition.
            //ProfileSkillPage profileSkillPageObj = new ProfileSkillPage();
            profileSkillPageObj.AddSkill(driver);
        }

        [Then(@"Profile skill was created successfully")]
        public void ThenProfileSkillWasCreatedSuccessfully()
        {
            throw new PendingStepException();
        }

        /*[Given(@"Navigate to the language via profile tab")]
        public void GivenNavigateToTheLanguageViaProfileTab()
        {
            throw new PendingStepException();
        }*/

        [When(@"Edit a New language in profile")]
        public void WhenEditANewLanguageInProfile()
        {
            profileSkillPageObj.EditSkill(driver);
        }

        [Then(@"Profile skill was successfully Edited")]
        public void ThenProfileSkillWasSuccessfullyEdited()
        {
            throw new PendingStepException();
        }

        [When(@"Delete a New language in the profile")]
        public void WhenDeleteANewLanguageInTheProfile()
        {
            profileSkillPageObj.DeleteSkill(driver);
        }

        [Then(@"Profile skill was Deleted successfully")]
        public void ThenProfileSkillWasDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
