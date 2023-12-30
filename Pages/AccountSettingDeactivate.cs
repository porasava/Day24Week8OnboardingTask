using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24Week8OnboardingTask.Pages
{
    public class AccountSettingDeactivate
    {
        //SelectedDeactivate
        public void SelectedDeactivate(IWebDriver driver1)
        {
            Wait.WaitToBeClickable(driver1, "Xpath", "//a[normalize-space()='Deactive']", 8);
            IWebElement deactivateTab = driver1.FindElement(By.XPath("//a[normalize-space()='Deactive']"));
            deactivateTab.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//button[normalize-space()='Deactivate']", 8);
            IWebElement deactivateLink = driver1.FindElement(By.XPath("//button[normalize-space()='Deactivate']"));
            deactivateLink.Click();

        }

        //ShowDeactivatedAccount
        public void ShowDeactivatedAccount(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement Firstname = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = Firstname.Text.Trim();
            string expectedMessage = "Deactivated account"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }
    }
}
