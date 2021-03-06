using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QA_Mars_OnboardingTask.Utilities;
using System;
using QA_Mars_OnboardingTask.Pages;
using NUnit.Framework;


namespace QA_Mars_OnboardingTask.Test
{
    [TestFixture]
    internal class Profile_Tests : CommonDriver
    {
        [Test, Order(1)]
        //static void Main(string[] args)
        //{
        public void CreateProfile_Test()
        {
            //// Open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // login page object initialization and definition.

            LoginPage loginPageObj = new();
            LoginPage.LoginSteps(driver);

            // Home page object initialization and definition.

            HomePage homePageObj = new HomePage();
            homePageObj.GoToHomePage(driver);
        }

        [Test, Order(2)]
        public void AddSkill()
        {
            // Profile skill page object initialization and definition.
            ProfileSkillPage profileSkillPageObj = new ProfileSkillPage();
            profileSkillPageObj.AddSkill(driver);

        }
        [Test, Order(3)]
        public void EditSkill()
        {
            //Edit skill
            ProfileSkillPage profileSkillPageObj = new ProfileSkillPage();
            profileSkillPageObj.EditSkill(driver);

        }
        [Test, Order(4)]
        public void DeleteSkill()
        {
            ProfileSkillPage profileSkillPageObj = new ProfileSkillPage();
            // Delete skill
            profileSkillPageObj.DeleteSkill(driver);
        }
    }
}
