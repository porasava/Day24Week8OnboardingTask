using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24Week8OnboardingTask.Pages
{
    public class AccountProfileSkill
    {
        private readonly IWebDriver driver1;

        public AccountProfileSkill(IWebDriver _driver)
        {
            driver1 = _driver;
        }
        By AccountButton => By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span");
        By GoToProfileDropdown1 => By.XPath("//a[normalize-space()='Go to Profile']");
        By skillTab1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");

        private IWebElement skillTab => driver1.FindElement(skillTab1);
        By addNewSkill1 => By.XPath("//div[@class='ui teal button' and text()='Add New']");
        private IWebElement AccountButton1 => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        private IWebElement GoToProfileDropdown => driver1.FindElement(GoToProfileDropdown1);
        private IWebElement addNewSkill => driver1.FindElement(addNewSkill1);
        private IWebElement SkillText => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private IWebElement skillLeveltext => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private IWebElement addSkillbutton => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private IWebElement editNewSkill => driver1.FindElement(By.XPath("//div[@id='account-profile-section']//table//td[3]/span[1]/i\r\n"));
        private IWebElement SkillEditText => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private IWebElement updateSkillbutton => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private IWebElement PopUpClose => driver1.FindElement(By.XPath("//a[@class='ns-close']"));
        By PopUp1 => By.XPath("/html/body/div[1]/div");
        private IWebElement skillPopUp => driver1.FindElement(PopUp1);
        private IWebElement removeSkillIcon => driver1.FindElement(By.XPath("//i[@class='remove icon']"));

        public void NavigateToAccountProfileSkill()
        {
            Wait.WaitForElementPresent(driver1, AccountButton, 8);
            AccountButton1.Click();
            Wait.WaitToBeClickable(driver1, GoToProfileDropdown1, 8);
            GoToProfileDropdown.Click();
            Wait.WaitToBeClickable(driver1, skillTab1, 5);
            skillTab.Click();
        }
        //AddANewSkill
        public void AddANewSkill(string skill, string skillLevel)
        {
            Wait.WaitToBeClickable(driver1, addNewSkill1, 5);
            addNewSkill.Click();
            SkillText.SendKeys(skill);
            skillLeveltext.Click();
            skillLeveltext.SendKeys(skillLevel);
            addSkillbutton.Click();
        }


        public void EditASkill(string skill)
        {
            Wait.WaitToBeClickable(driver1, skillTab1, 5);
            skillTab.Click();
            Thread.Sleep(1000);
            editNewSkill.Click();
            SkillEditText.Clear();
            SkillEditText.SendKeys(skill);
            updateSkillbutton.Click();
        }

        //SkillShouldEditSuccessfully
        public void SkillShouldEditSuccessfully()
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, PopUp1, 5);
            Wait.ElementIsVisible(driver1, PopUp1, 5);
            string actualMessage = skillPopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your skills";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //DeleteASkill
        public void DeleteASkill(string skillDelete)
        {
            Thread.Sleep(1000);
            string skillToRemove = skillDelete; // Replace with the Skill name based on user input
            // Find the table row that contains the specified Skill
            IWebElement rowContainingSkill = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{skillToRemove}')]]"));
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingSkill.FindElement(By.XPath(".//i[@class='remove icon']"));
            // Click the "Remove" icon
            removeIcon.Click();
        }

        //SkillShouldBeRemoveSuccessfully
        public void SkillShouldBeRemoveSuccessfully()
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, PopUp1, 5);
            string actualMessage = skillPopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been deleted";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //ShowNewSkill
        public void ShowNewSkill()
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, PopUp1, 5);
            string actualMessage = skillPopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been added to your skills";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //ErrorPleaseEnterSkillAndExperienceLevel
        public void ErrorPleaseEnterSkillAndExperienceLevel()
        {
            Wait.ElementIsVisible(driver1, PopUp1, 5);
            string actualMessage = skillPopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "Please enter skill and experience level";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //checkExistingSkill
        public void checkExistingSkill()
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
            removeSkillIcon.Click();
            // Add any additional waits or logic needed after deletion
        }
    }
}
