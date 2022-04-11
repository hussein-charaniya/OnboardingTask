using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QA_Mars_OnboardingTask.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Mars_OnboardingTask.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginSteps()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // login page object initialization and definition.
            LoginPage loginPageObj = new LoginPage();
            LoginPage.LoginSteps(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }


    }
}