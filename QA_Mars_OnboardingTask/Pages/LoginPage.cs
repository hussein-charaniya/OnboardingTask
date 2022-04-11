using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
/*using QA_Mars_OnboardingTask.Utilities;*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Mars_OnboardingTask.Pages
{
    internal class LoginPage 
    {
        public static void LoginSteps(IWebDriver driver)
        {
            // launch Local host portal
            driver.Navigate().GoToUrl("http://localhost:5000");

            try
            {


                IWebElement signin = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                signin.Click();

                // Identify username text box
                IWebElement emailId = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                emailId.Click();
                emailId.SendKeys("husseincharaniya@gmail.com");

                IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                password.Click();
                password.SendKeys("Farusein1$");

                IWebElement login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                login.Click();

            }

            catch (Exception ex)
            {
                Assert.Fail("Page did not launch", ex.Message);
                throw;
            }
            //Check if the user is logged in successfully
            //IWebElement hihussein = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/div[1]/div[2]/div/span"));

        }
    }
}
