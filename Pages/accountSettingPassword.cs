using Day24Week8OnboardingTask.Utilities;
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
    public class accountSettingPassword
    {
        public void NavigateToAccountSettings(IWebDriver driver1)
        {
            Wait.ElementIsVisible(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 8);
            IWebElement AccountButton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            AccountButton.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//a[normalize-space()='Account Settings']", 8);
            IWebElement accountSettingDropdown = driver1.FindElement(By.XPath("//a[normalize-space()='Account Settings']"));
            accountSettingDropdown.Click();

        }

        //
        public void EditPasswordInTheAccountSettingPage(IWebDriver driver1, string currentPassword, string newPassword, string confirmPassword)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.ElementIsVisible(driver1, "Xpath", "//input[@id='Password']", 8);
            IWebElement editPasswordButton = driver1.FindElement(By.XPath("//input[@id='Password']"));
            editPasswordButton.Click();
            IWebElement currentPasswordText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Current Password']")));
            currentPasswordText.SendKeys(currentPassword);
            IWebElement NewPasswordText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='New Password']")));
            NewPasswordText.SendKeys(newPassword);
            IWebElement ConfirmPasswordText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Confirm Password']")));
            ConfirmPasswordText.SendKeys(confirmPassword);
            IWebElement savePasswordButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Save']")));
            savePasswordButton.Click();

        }

        public void refreshPasswordpage(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.ElementIsVisible(driver1, "Xpath", "//a[normalize-space()='Deactive']", 8);
            IWebElement clickOthertab = driver1.FindElement(By.XPath("//a[normalize-space()='Deactive']"));
            clickOthertab.Click();
            IWebElement accountTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Account']")));
            accountTab.Click();
        }

    }
}
