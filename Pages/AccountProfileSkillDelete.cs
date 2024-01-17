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
    public class AccountProfileSkillDelete

    {
        private readonly IWebDriver driver1;

        public AccountProfileSkillDelete(IWebDriver _driver)
        {
            driver1 = _driver;
        }
        By deleteError1 => By.XPath("/html/body/div[1]/div");
        private IWebElement deleteError => driver1.FindElement(deleteError1);

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
            Wait.ElementIsVisible(driver1, deleteError1, 5);
            string actualMessage = deleteError.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been deleted";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }
    }
}
