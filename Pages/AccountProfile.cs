using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Day24Week8OnboardingTask.Pages
{
    public class AccountProfile
    {
        public void LogedIntoSkillWebsite(IWebDriver driver1, string username, string password)
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.NavigateToSkillsWeb(driver1);
            loginPageObj.InputUsernameAndPassword(driver1, username, password);
            loginPageObj.ClickOnLogin(driver1);

        }

        public void NavigateToAccountProfile(IWebDriver driver1)
        {
            Wait.ElementIsVisible(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 8);
            IWebElement AccountButton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            AccountButton.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//a[normalize-space()='Go to Profile']", 8);
            IWebElement GoToProfileDropdown = driver1.FindElement(By.XPath("//a[normalize-space()='Go to Profile']"));
            GoToProfileDropdown.Click();

        }


        // AddNewLanguage
        public void addNewLanguage(IWebDriver driver1, string language, string languageLevel)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 8);
            IWebElement editIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            editIcon.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 8);
            IWebElement languageText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            Thread.Sleep(1000);
            languageText.Clear();
            languageText.SendKeys(language);

            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 8);
            IWebElement languageLeveldropdown = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLeveldropdown.Click();
            languageLeveldropdown.SendKeys(languageLevel);

            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 8);
            IWebElement languageAdd = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            languageAdd.Click();

        }

        //LanguageShouldBeAddSuccessfully
        public void languageShouldBeAddSuccessfully(IWebDriver driver1)
        {

            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement language = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            string actualMessage = language.Text.Trim();

            // Set the expected message for the language element
            string expectedMessage = "Spanish"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

            // Similar process for the second element (languageLevel)
            IWebElement languageLevel = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            string actualMessage2 = languageLevel.Text.Trim();

            // Set the expected message for the language level element
            string expectedMessage2 = "Basic"; // Replace with the actual expected text

            // Assert and print the expected and actual message for language level
            Assert.That(actualMessage2.Equals(expectedMessage2, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage2 + "', Actual: '" + actualMessage2 + "'");

        }

        //RemoveLanguage
        public void RemoveLanguage(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 8);
            IWebElement deleteIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteIcon.Click();

        }


        //LanguageShouldBeRemoveSuccessful
        public void LanguageShouldBeRemoveSuccessful(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been deleted from your languages";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
            Thread.Sleep(1000);
        }


        //ErrorPleaseenterlanguageandlevel
        public void ErrorPleaseenterlanguageandlevel(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // Assuming you expect the text to be removed and thus to be an empty string
            string expectedMessage = "Please enter language and level"; // Set this to the expected text if it's not supposed to be empty

            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The text was not removed as expected. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
            Thread.Sleep(1000);
        }

        //EditALanguage
        public void EditALanguage(IWebDriver driver1, string languageEdit)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 8);
            IWebElement editIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editIcon.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input", 8);
            IWebElement languageText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            Thread.Sleep(1000);
            languageText.Clear();
            languageText.SendKeys(languageEdit);

            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 8);
            IWebElement languageUpdate = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            languageUpdate.Click();

        }

        //LanguageShouldBeEditSuccessfully
        public void LanguageShouldBeEdited(IWebDriver driver1, string languageEdit)
        {
            Thread.Sleep(2000);
            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement languagePopUp = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = languagePopUp.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your languages";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //DeleteALanguage
        public void DeleteALanguage(IWebDriver driver1, string languageDelete)
        {
            Thread.Sleep(2000);
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 8);

            string languageToRemove = languageDelete; // Replace with the language name based on user input

            // Find the table row that contains the specified language
            IWebElement rowContainingLanguage = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{languageToRemove}')]]"));

            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingLanguage.FindElement(By.XPath(".//i[@class='remove icon']"));

            // Click the "Remove" icon
            removeIcon.Click();

        }

        //AddANewSkill
        public void AddANewSkill(IWebDriver driver1, string skill, string skillLevel)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement skillTab = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")));
            skillTab.Click();
            Thread.Sleep(1000);
            IWebElement addNewSkill = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//div[@class='ui teal button' and text()='Add New']")));
            addNewSkill.Click();
            IWebElement Skill = wait.Until(ExpectedConditions.
           ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")));
            Skill.SendKeys(skill);
            IWebElement skillLeveltext = wait.Until(ExpectedConditions.
           ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")));
            skillLeveltext.Click();
            skillLeveltext.SendKeys(skillLevel);
            IWebElement addSkillbutton = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")));
            addSkillbutton.Click();

        }

        //ShowNewSkill
        public void ShowNewSkill(IWebDriver driver1)
        {

            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement skillPopUp = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = skillPopUp.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been added to your skills";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }

        //RemoveLanguage
        public void DeleteASkill(IWebDriver driver1, string skillDelete)
        {
            Thread.Sleep(2000);
            string skillToRemove = skillDelete; // Replace with the Skill name based on user input

            // Find the table row that contains the specified Skill
            IWebElement rowContainingSkill = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{skillToRemove}')]]"));

            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingSkill.FindElement(By.XPath(".//i[@class='remove icon']"));

            // Click the "Remove" icon
            removeIcon.Click();

        }


        //LanguageShouldBeRemoveSuccessful
        public void SkillShouldBeRemoveSuccessfully(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been deleted";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //ErrorPleaseEnterSkillAndExperienceLevel
        public void ErrorPleaseEnterSkillAndExperienceLevel(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Please enter skill and experience level";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //EditASkill
        public void EditASkill(IWebDriver driver1, string skill)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement skillTab = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")));
            skillTab.Click();
            Thread.Sleep(1000);
            IWebElement editNewSkill = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//div[@id='account-profile-section']//table//td[3]/span[1]/i\r\n")));
            editNewSkill.Click();
            IWebElement Skill = wait.Until(ExpectedConditions.
           ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")));
            Skill.Clear();
            Skill.SendKeys(skill);
            IWebElement updateSkillbutton = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")));
            updateSkillbutton.Click();

        }

        //SkillShouldEditSuccessfully
        public void SkillShouldEditSuccessfully(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your skills";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

    }
}
