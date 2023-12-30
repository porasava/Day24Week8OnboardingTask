using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24Week8OnboardingTask.Pages
{
    public class AccountSettingShareSkill
    {

        //ErrorTitleIsRequired
        public void ErrorTitleIsRequired(IWebDriver driver1)
        {

            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='twelve wide column']//div//div[@class='ui basic red prompt label transition visible']", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[@class='twelve wide column']//div//div[@class='ui basic red prompt label transition visible']"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Title is required";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ErrorDescriptionIsRequired
        public void ErrorDescriptionIsRequired(IWebDriver driver1)
        {

            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='tooltip-target ui grid']//div[@class='row']//div[@class='ui twelve wide column']//div//div[@class='ui basic red prompt label transition visible']", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[@class='row']//div[@class='ui twelve wide column']//div//div[@class='ui basic red prompt label transition visible']"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Description is required";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ErrorCategoryIsRequired
        public void ErrorCategoryIsRequired(IWebDriver driver1)
        {

            Wait.ElementIsVisible(driver1, "Xpath", "//div[normalize-space()='Category is required']", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[normalize-space()='Category is required']"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Category is required";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ErrorTagsAreRequired
        public void ErrorTagsAreRequired(IWebDriver driver1)
        {

            Wait.ElementIsVisible(driver1, "Xpath", "//div[contains(text(),'Tags are required')]", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[contains(text(),'Tags are required')]"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Tags are required";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ErrorSkill_ExchangeAreRequired
        public void ErrorSkillExchangeAreRequired(IWebDriver driver1)
        {

            Wait.ElementIsVisible(driver1, "Xpath", "//div[contains(text(),'Tag is required')]", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[contains(text(),'Tag is required')]"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Tag is required";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

    }
}
