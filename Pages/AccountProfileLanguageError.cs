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
    public class AccountProfileLanguageError
    {
        private readonly IWebDriver driver1;

        public AccountProfileLanguageError(IWebDriver _driver)
        {
            driver1 = _driver;
        }
        By Language1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]");
        By deleteError1 => By.XPath("/html/body/div[1]/div");
        private IWebElement Language => driver1.FindElement(Language1);
        private IWebElement LanguageLevel => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
        private IWebElement deleteError => driver1.FindElement(deleteError1);
        private IWebElement PopUpClose => driver1.FindElement(By.XPath("//a[@class='ns-close']"));

        //LanguageShouldBeAddSuccessfully
        public void languageShouldBeAddSuccessfully( string language, string languageLevel)
        {
            Wait.WaitForElementPresent(driver1, Language1, 8);
            string actualMessage = Language.Text.Trim();
            // Set the expected message for the language element
            string expectedMessage = language.Trim();  // Replace with the actual expected text
            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
            // Similar process for the second element (languageLevel)
            string actualMessage2 = LanguageLevel.Text.Trim();
            // Set the expected message for the language level element
            string expectedMessage2 = languageLevel.Trim();  // Replace with the actual expected text
            // Assert and print the expected and actual message for language level
            Assert.That(actualMessage2.Equals(expectedMessage2, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage2 + "', Actual: '" + actualMessage2 + "'");
        }

        //ErrorThisLanguageIsAlreadyExistInYourLanguageList
        public void ErrorThisLanguageIsAlreadyExistInYourLanguageList()
        {
            PopUpClose.Click();
            Wait.WaitToExist(driver1, deleteError1, 5);
            string actualMessage = deleteError.Text.Trim();
            // Assuming you expect the text to be removed and thus to be an empty string
            string expectedMessage = "This language is already exist in your language list."; // Set this to the expected text if it's not supposed to be empty
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
        }

        //ErrorThisLanguageIsAlreadyAddedToYourLanguageList
        public void ErrorThisLanguageIsAlreadyAddedToYourLanguageList()
        {
            PopUpClose.Click();
            Wait.WaitToExist(driver1, deleteError1, 5);
            Wait.WaitToExist(driver1, deleteError1, 5);
            string actualMessage = deleteError.Text.Trim();
            // Assuming you expect the text to be removed and thus to be an empty string
            string expectedMessage = "This language is already added to your language list."; // Set this to the expected text if it's not supposed to be empty
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
        }

        //ErrorPleaseenterlanguageandlevel
        public void ErrorPleaseenterlanguageandlevel()
        {
            Wait.WaitToExist(driver1, deleteError1, 5);
            string actualMessage = deleteError.Text.Trim();
            // Assuming you expect the text to be removed and thus to be an empty string
            string expectedMessage = "Please enter language and level"; // Set this to the expected text if it's not supposed to be empty
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The text was not removed as expected. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
        }
    }
}
