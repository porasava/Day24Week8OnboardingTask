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
    public class AccountProfileSkillError
    {
        private readonly IWebDriver driver1;

        public AccountProfileSkillError(IWebDriver _driver)
        {
            driver1 = _driver;
        }
        By PopUp1 => By.XPath("/html/body/div[1]/div");
        private IWebElement skillPopUp => driver1.FindElement(PopUp1);

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
    }
}
