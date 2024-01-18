using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;


namespace Day24Week8OnboardingTask.Pages
{
    public class AccountProfileLanguageAdd
    {
        private readonly IWebDriver driver1;

        public AccountProfileLanguageAdd(IWebDriver _driver)
        {
            driver1 = _driver;
        }

        By AccountButton => By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span");
        By GoToProfileDropdown1 => By.XPath("//a[normalize-space()='Go to Profile']");
        By languageAdd1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
        By languageText1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
        private IWebElement AccountButton1 => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        private IWebElement GoToProfileDropdown => driver1.FindElement(GoToProfileDropdown1);
        private IWebElement editIcon => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageText => driver1.FindElement(languageText1);
        private IWebElement languageLeveldropdown => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private IWebElement languageAdd => driver1.FindElement(languageAdd1);
        private IWebElement languagecancel => driver1.FindElement(By.XPath("//input[@value='Cancel']"));
       
        public void NavigateToAccountProfile()
        {
            Wait.WaitForElementPresent(driver1, AccountButton, 8);
            AccountButton1.Click();
            Wait.WaitToBeClickable(driver1, GoToProfileDropdown1, 8);
            GoToProfileDropdown.Click();
        }

        // AddNewLanguage
        public void addNewLanguage(string language, string languageLevel)
        {
            language = language.Replace("[SPACE]", " ");
            language = language.Replace("[NEWLINE]", "\n");
            editIcon.Click();
            Thread.Sleep(1000);
            languageText.Clear();
            languageText.SendKeys(language);
            languageLeveldropdown.Click();
            languageLeveldropdown.SendKeys(languageLevel);
        }

        //Click Add Language
        public void clickAddLanguage()
        {
            languageAdd.Click();
        }

        public void clickCancelLanguage()
        {
            languagecancel.Click();
        }

        public void checkAddLanguageButtonDisappear()
        {
            bool isElementPresent;
            clickAddLanguage();
            Thread.Sleep(1000);
            Wait.WaitForElementToDisappear(driver1, languageAdd1,8);
            try
            {
                // Try to find the element
               isElementPresent = languageAdd != null && languageAdd.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, it's not present
                isElementPresent = false;
            }
            // Assert that the element is not present or not displayed
            Assert.That(isElementPresent, Is.False, "The 'languageAdd' button should not be visible.");

        }

    }
}
