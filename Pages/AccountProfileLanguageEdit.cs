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
    public class AccountProfileLanguageEdit
    {
        private readonly IWebDriver driver1;

        public AccountProfileLanguageEdit(IWebDriver _driver)
        {
            driver1 = _driver;
        }
        By editIcon1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");
        By languagePopUp1 => By.XPath("/html/body/div[1]/div");
        private IWebElement editIcon => driver1.FindElement(editIcon1);
        private IWebElement languageText => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private IWebElement languageUpdate => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private IWebElement languagePopUp => driver1.FindElement(languagePopUp1);

        //EditALanguage
        public void EditALanguage( string languageEdit)
        {
            languageEdit = languageEdit.Replace("[SPACE]", " ");
            Wait.WaitForElementPresent(driver1, editIcon1, 9);
            editIcon.Click();
            languageText.Clear();
            languageText.SendKeys(languageEdit);
            languageUpdate.Click();
        }

        //LanguageShouldBeEditSuccessfully
        public void LanguageShouldBeEdited(string languageEdit)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, languagePopUp1, 8);
            string actualMessage = languagePopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your languages";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }
    }
}
