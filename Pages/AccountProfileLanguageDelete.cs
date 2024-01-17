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
    public class AccountProfileLanguageDelete
    {
        private readonly IWebDriver driver1;

        public AccountProfileLanguageDelete(IWebDriver _driver)
        {
            driver1 = _driver;
        }
        By deleteIcon1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i");
        By deleteError1 => By.XPath("/html/body/div[1]/div");
        private IWebElement deleteIcon => driver1.FindElement(deleteIcon1);
        private IWebElement deleteError => driver1.FindElement(deleteError1);
        private IWebElement PopUpClose => driver1.FindElement(By.XPath("//a[@class='ns-close']"));

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
    }
}
