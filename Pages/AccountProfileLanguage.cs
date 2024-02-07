using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;


namespace Day24Week8OnboardingTask.Pages
{
    public class AccountProfileLanguage
    {
        private readonly IWebDriver driver1;

        public AccountProfileLanguage(IWebDriver _driver)
        {
            driver1 = _driver;
        }

        By AccountButton => By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span");
        By GoToProfileDropdown1 => By.XPath("//a[normalize-space()='Go to Profile']");
        By languageAdd1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
        By languageText1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
        private IWebElement AccountButton1 => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        private IWebElement GoToProfileDropdown => driver1.FindElement(GoToProfileDropdown1);
        private IWebElement AddIcon => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageText => driver1.FindElement(languageText1);
        private IWebElement languageLeveldropdown => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private IWebElement languageAdd => driver1.FindElement(languageAdd1);
        private IWebElement languagecancel => driver1.FindElement(By.XPath("//input[@value='Cancel']"));
        By editIcon1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");
        By languagePopUp1 => By.XPath("/html/body/div[1]/div");
        private IWebElement editIcon => driver1.FindElement(editIcon1);
        private IWebElement languageTextedit => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private IWebElement languageUpdate => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private IWebElement languagePopUp => driver1.FindElement(languagePopUp1);
        By deleteIcon1 => By.XPath("//i[@class='remove icon']");
        By deleteError1 => By.XPath("/html/body/div[1]/div");
        private IWebElement deleteIcon => driver1.FindElement(deleteIcon1);
        private IWebElement deleteError => driver1.FindElement(deleteError1);

        By Language1 => By.XPath("//tbody//tr//td[1]");
        private IWebElement Language => driver1.FindElement(Language1);
        private IWebElement LanguageLevel => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
        private IWebElement PopUpClose => driver1.FindElement(By.XPath("//a[@class='ns-close']"));

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
            Thread.Sleep(1000);
            AddIcon.Click();
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

        //EditALanguage
        public void EditALanguage(string languageEdit)
        {
            languageEdit = languageEdit.Replace("[SPACE]", " ");
            Wait.WaitForElementPresent(driver1, editIcon1, 9);
            editIcon.Click();
            languageTextedit.Clear();
            languageTextedit.SendKeys(languageEdit);
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

        //RemoveLanguage
        public void RemoveLanguage()
        {
            Wait.WaitForElementPresent(driver1, deleteIcon1, 8);
            deleteIcon.Click();
            Thread.Sleep(1000);
        }

        //LanguageShouldBeRemoveSuccessful
        public void LanguageShouldBeRemoveSuccessful()
        {
            Wait.WaitToExist(driver1, deleteError1, 5);// first popup
            Thread.Sleep(2000);
            Wait.WaitToExist(driver1, deleteError1, 5);//second pop up
            string actualMessage = deleteError.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been deleted from your languages";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //DeleteALanguage
        public void DeleteALanguage(string languageDelete)
        {
            Wait.WaitForElementPresent(driver1, deleteIcon1, 8);
            string languageToRemove = languageDelete; // Replace with the language name based on user input
            // Find the table row that contains the specified language
            IWebElement rowContainingLanguage = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{languageToRemove}')]]"));
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingLanguage.FindElement(By.XPath(".//i[@class='remove icon']"));
            // Click the "Remove" icon
            removeIcon.Click();
        }

        //LanguageShouldBeAddSuccessfully
        public void languageShouldBeAddSuccessfully(string language, string languageLevel)
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


        //CheckExistingLanguage
        public void CheckExistingLanguage()
        {
            Thread.Sleep(1000);
            // Loop until no more data is present
            while (IsDataPresent())
            {
                DeleteData();
            }
        }

        public bool IsDataPresent()
        {
            // Implement logic to check if data is present
            // For example, checking if a specific element or row exists
            try
            {
                Thread.Sleep(1000);
                driver1.FindElement(By.XPath("//i[@class='remove icon']"));
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void DeleteData()
        {
            // Implement the logic to delete the data
            // For example, clicking a delete button
            deleteIcon.Click();
            // Add any additional waits or logic needed after deletion
        }
    }
}
