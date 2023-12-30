using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day24Week8OnboardingTask.Utilities;
using Day24Week8OnboardingTask.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Day24Week8OnboardingTask.Pages
{
    public class AccountSettingDashboard :CommonDriver
    {
        //NavigateToAccountSettingsAndClickOnDashboard
        public void SelectedDashboard(IWebDriver driver1)
        {
            Wait.WaitToBeClickable(driver1, "Xpath", "//a[normalize-space()='Dashboard']", 8);
            IWebElement DashboardTab = driver1.FindElement(By.XPath("//a[normalize-space()='Dashboard']"));
            DashboardTab.Click();
        }

        ////h1[normalize-space()='Notifications']
        public void notificationPage(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//h1[normalize-space()='Notifications']", 5);
            IWebElement notification = driver1.FindElement(By.XPath("//h1[normalize-space()='Notifications']"));
            string actualMessage = notification.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Notifications";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }
    }
}
