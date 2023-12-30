using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24Week8OnboardingTask.Pages
{
    public class HomePageSearchSkill
    {
        public void DisplaySkillOnTheResultPage(IWebDriver driver1)
        {

            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='four wide column']//div//h3", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[@class='four wide column']//div//h3"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Refine Results";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

    }
}
