using OpenQA.Selenium;
using System;
using System.Threading;

namespace QA_Mars_OnboardingTask.Pages
{
    internal class HomePage
    {
        public void GoToHomePage(IWebDriver driver)
        {
            // Go to profile page
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);
            Thread.Sleep(5000);
            IWebElement languageTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageTab.Click();
           
        }

        internal void GoToHomePage(object driver)
        {
            throw new NotImplementedException();
        }
    }
}
