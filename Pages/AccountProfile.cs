using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Day24Week8OnboardingTask.Pages
{
    public class AccountProfile
    {
        public void LogedIntoSkillWebsite(IWebDriver driver1,string username, string password)
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



        //EditFirstname
        public void EditFirstname(IWebDriver driver1, string firstname)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i", 8);
            IWebElement DropDownIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            DropDownIcon.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]", 8);
            IWebElement FirstnameText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            Thread.Sleep(1000);
            FirstnameText.Clear();
            FirstnameText.SendKeys(firstname);
            Wait.WaitToBeClickable(driver1, "Xpath", "//button[@class='ui teal button']", 8);
            IWebElement FirstnameSave = driver1.FindElement(By.XPath("//button[@class='ui teal button']"));
            FirstnameSave.Click();
            
        }

        //NewFirstname
        public void NewFirstname(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='title']", 5);
            IWebElement NewFirstname = driver1.FindElement(By.XPath("//div[@class='title']"));
            string actualMessage = NewFirstname.Text.Trim();
            string expectedMessage = "TananyaEdit Happy"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        // EditBackToTheOriginalFirstname
        public void EditBackToTheOriginalFirstname(IWebDriver driver1,string originalFirstName)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i", 8);
            IWebElement DropDownIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            DropDownIcon.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]", 8);
            IWebElement originalFirstnameText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            Thread.Sleep(1000);
            originalFirstnameText.Clear();
            originalFirstnameText.SendKeys(originalFirstName);
            Wait.WaitToBeClickable(driver1, "Xpath", "//button[@class='ui teal button']", 8);
            IWebElement FirstnameSave = driver1.FindElement(By.XPath("//button[@class='ui teal button']"));
            FirstnameSave.Click();

            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='title']", 5);
            IWebElement originalFirstname = driver1.FindElement(By.XPath("//div[@class='title']"));
            string actualMessage = originalFirstname.Text.Trim();
            string expectedMessage = "Tananya Happy"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //EditLastname
        public void EditLastname(IWebDriver driver1, string lastnameEdit)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i", 8);
            IWebElement DropDownIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            DropDownIcon.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]", 8);
            IWebElement LastnameText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            Thread.Sleep(1000);
            LastnameText.Clear();
            LastnameText.SendKeys(lastnameEdit);
            Wait.WaitToBeClickable(driver1, "Xpath", "//button[@class='ui teal button']", 8);
            IWebElement LastnameSave = driver1.FindElement(By.XPath("//button[@class='ui teal button']"));
            LastnameSave.Click();

        }

        //ShowNewLastname
        public void ShowNewLastname(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.WaitToExist(driver1, "Xpath", "//div[@class='title']", 5);
            IWebElement Lastname = driver1.FindElement(By.XPath("//div[@class='title']"));
            string actualMessage = Lastname.Text.Trim();

            string expectedStaticPart = "HappyEdit";// The substring you expect to find in the text

           // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }

        //EditBackToTheOriginalLastname
        public void EditBackToTheOriginalLastname(IWebDriver driver1, string originalLastName)
        {
            Wait.ElementIsVisible(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i", 8);
            IWebElement DropDownIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            DropDownIcon.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]", 8);
            IWebElement originalLastnameText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            Thread.Sleep(1000);
            originalLastnameText.Clear();
            originalLastnameText.SendKeys(originalLastName);
            Wait.WaitToBeClickable(driver1, "Xpath", "//button[@class='ui teal button']", 8);
            IWebElement LastnameSave = driver1.FindElement(By.XPath("//button[@class='ui teal button']"));
            LastnameSave.Click();
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='title']", 5);
            IWebElement originalLastname = driver1.FindElement(By.XPath("//div[@class='title']"));
            string actualMessage = originalLastname.Text.Trim();
            string expectedMessage = "Tananya Happy"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }


        //EditDescription
        public void editDescription(IWebDriver driver1, string description)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 8);
            IWebElement editIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            editIcon.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 8);
            IWebElement descriptionText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            Thread.Sleep(1000);
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 8);
            IWebElement descriptionSave = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            descriptionSave.Click();

        }


        //DescriptionShouldBeEditSuccessfully
        public void descriptionShouldBeEditSuccessfully(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span", 5);
            IWebElement description = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            string actualMessage = description.Text.Trim();

            // Set the expected message for the language element
            string expectedMessage = "Hello Description"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //EditBackToTheOriginalDescription
        public void EditBackToTheOriginalDescription(IWebDriver driver1, string originalDescription)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 8);
            IWebElement editIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            editIcon.Click();
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 8);
            IWebElement descriptionText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            Thread.Sleep(1000);
            descriptionText.Clear();
            descriptionText.SendKeys(originalDescription);
            Wait.WaitToBeClickable(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 8);
            IWebElement descriptionSave = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            descriptionSave.Click();

            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span", 5);
            IWebElement originalDescriptionText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            string actualMessage = originalDescriptionText.Text.Trim();
            string expectedMessage = "Original"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

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

        //AddANewEducation
        public void AddANewEducation(IWebDriver driver1, string universityName, string country, string title, string degree, string yearOfGraduate)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement educationTab = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//a[normalize-space()='Education']")));
            educationTab.Click();
            Thread.Sleep(1000);
            IWebElement addNewEducation = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']")));
            addNewEducation.Click();
            IWebElement university = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='instituteName']")));
            university.Clear();
            university.SendKeys(universityName);
            IWebElement countryDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name='country']")));
            countryDropdown.Click();
            countryDropdown.SendKeys(country);
            IWebElement titleDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name='title']")));
            titleDropdown.Click();
            titleDropdown.SendKeys(title);
            IWebElement degreeText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='degree']")));
            degreeText.Clear();
            degreeText.SendKeys(degree);
            IWebElement yearDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name='yearOfGraduation']")));
            yearDropdown.Click();
            yearDropdown.SendKeys(yearOfGraduate);
            IWebElement addEducation = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='sixteen wide field']//input[@value='Add']")));
            addEducation.Click();
        }

        //EducationShouldBeAddSuccessfully
        public void EducationShouldBeAddSuccessfully(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Education has been added";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }


        //DeleteAEducation
        public void DeleteAEducation(IWebDriver driver1, string universityNameDelete)
        {
            Thread.Sleep(2000);
            string educationToRemove = universityNameDelete; // Replace with the language name based on user input

            // Find the table row that contains the specified 
            IWebElement rowContainingEducation = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{educationToRemove}')]]"));
            Thread.Sleep(2000);
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingEducation.FindElement(By.XPath("//i[@class='remove icon']"));

            // Click the "Remove" icon
            removeIcon.Click();

        }


        //EducationShouldDeleteSuccessfully
        public void EducationShouldDeleteSuccessfully(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Education entry successfully removed";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //EducationErrorPleaseEnterAllTheFields
        public void EducationErrorPleaseEnterAllTheFields(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Please enter all the fields";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //EditEducation
        public void EditEducation(IWebDriver driver1, string universityNameEdit, string countryEdit, string titleEdit, string degreeEdit, string yearOfGraduateEdit)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement educationTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Education']")));
            educationTab.Click();
            Thread.Sleep(1000);
            IWebElement editEducation = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']")));
            editEducation.Click();
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.AddANewEducation(driver1, universityNameEdit, countryEdit, titleEdit, degreeEdit, yearOfGraduateEdit);
            IWebElement educationUpdate = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@value = 'Update']")));
            educationUpdate.Click();
        }

        //AddANewCertification
        public void AddANewCertification(IWebDriver driver1, string certificateOrAward, string from, string year)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement certificationTab = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//a[normalize-space()='Certifications']")));
            certificationTab.Click();
            Thread.Sleep(1000);
            IWebElement addNewcertification = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']")));
            addNewcertification.Click();
            IWebElement certificationText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='certificationName']")));
            certificationText.Clear();
            certificationText.SendKeys(certificateOrAward);
            IWebElement fromText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='certificationFrom']")));
            fromText.Clear();
            fromText.SendKeys(from);
            IWebElement yearDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name='certificationYear']")));
            yearDropdown.Click();
            yearDropdown.SendKeys(year);
            IWebElement addCertification = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@value='Add']")));
            addCertification.Click();
        }

        //CertificationShouldBeAddSuccessfully
        public void CertificationShouldBeAddSuccessfully(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been added to your certification";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //DeleteCertification
        public void DeleteCertification(IWebDriver driver1, string certificationDelete)
        {
            Thread.Sleep(2000);
            string certificationToRemove = certificationDelete; 

            // Find the table row that contains the specified 
            IWebElement rowContainingCertification = driver1.FindElement(By.XPath($"//td[normalize-space()='{certificationToRemove}']"));
  
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingCertification.FindElement(By.XPath("//i[@class='remove icon']"));

            // Click the "Remove" icon
            removeIcon.Click();

        }

       //CertificationShouldDeleteSuccessfully
        public void CertificationShouldDeleteSuccessfully(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been deleted from your certification";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }


        //ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear
        public void ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear(IWebDriver driver1)
        {
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Please enter Certification Name, Certification From and Certification Year";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //EditACertification
        public void EditACertification(IWebDriver driver1, string certificateOrAwardEdit, string fromEdit, string yearEdit)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement certificationTab = wait.Until(ExpectedConditions.
            ElementToBeClickable(By.XPath("//a[normalize-space()='Certifications']")));
            certificationTab.Click();
            Thread.Sleep(1000);
            IWebElement editcertification = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']")));
            editcertification.Click();
            IWebElement certificationText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='certificationName']")));
            certificationText.Clear();
            certificationText.SendKeys(certificateOrAwardEdit);
            IWebElement fromText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='certificationFrom']")));
            fromText.Clear();
            fromText.SendKeys(fromEdit);
            IWebElement yearDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name='certificationYear']")));
            yearDropdown.Click();
            yearDropdown.SendKeys(yearEdit);

            IWebElement editCertification = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@value='Update']")));
            editCertification.Click();
        }

        //CertificationShouldBeEdit
        public void CertificationShouldBeEdit(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, "Xpath", "/html/body/div[1]/div", 5);
            IWebElement deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = deleteError.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your certification";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }


    }
}
