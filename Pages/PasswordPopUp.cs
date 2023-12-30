using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24Week8OnboardingTask.Pages
{
    public class PasswordPopUp
    {

        //NavigateToPasswordPopUp
        public void NavigateToPasswordPopUp(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 8);
            IWebElement AccountButton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            AccountButton.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//a[normalize-space()='Change Password']", 8);
            IWebElement changePasswordDropdown = driver1.FindElement(By.XPath("//a[normalize-space()='Change Password']"));
            changePasswordDropdown.Click();

        }


        //ChangePassword
        public void ChangePassword(IWebDriver driver1, string currentPassword, string newPassword, string confirmPassword)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement CurrentPasswordText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Current Password']")));
            CurrentPasswordText.SendKeys(currentPassword);
            IWebElement NewPasswordText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='New Password']")));
            NewPasswordText.SendKeys(newPassword);
            IWebElement ConfirmPasswordText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Confirm Password']")));
            ConfirmPasswordText.SendKeys(confirmPassword);
            IWebElement savePasswordButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@role='button']")));
            savePasswordButton.Click();
        }

        //ShowPasswordChanged
        public void ShowPasswordChanged(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement NewFirstname = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = NewFirstname.Text.Trim();
            string expectedMessage = "Password Changed Successfully"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
            Thread.Sleep(3000);
        }

        //PasswordVerificationFailed
        public void PasswordVerificationFailed(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement NewFirstname = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = NewFirstname.Text.Trim();
            string expectedMessage = "Password Verification Failed"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //ErrorWhileUpdatingPasswordDetails
        public void ErrorWhileUpdatingPasswordDetails(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement NewFirstname = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = NewFirstname.Text.Trim();
            string expectedMessage = "Error while Updating Password details"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //PleaseFillAllTheDetailsBeforeSubmit
        public void PleaseFillAllTheDetailsBeforeSubmit(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement NewFirstname = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = NewFirstname.Text.Trim();
            string expectedMessage = "Please fill all the details before Submit"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }


        //ErrorPasswordsRequiredAtLeastCharacters
        public void ErrorPasswordsRequiredAtLeastCharacters(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement NewFirstname = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = NewFirstname.Text.Trim();
            string expectedMessage = "Passwords required at least 6 characters"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }


        //ErrorPasswordsDoesNotMatch
        public void ErrorPasswordsDoesNotMatch(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement NewFirstname = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = NewFirstname.Text.Trim();
            string expectedMessage = "Passwords does not match"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }
    }
}
