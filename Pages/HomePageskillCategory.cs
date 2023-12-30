using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.Pages
{
    public class HomePageskillCategory
    {
        //ClickOnLink
        public void ClickOnLink(IWebDriver driver1, string skill)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));

            if (!string.IsNullOrEmpty(skill))
            {
                IWebElement GoToHomePage = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//a[normalize-space()='Mars Logo']")));
                GoToHomePage.Click();
                Thread.Sleep(1000);
                IWebElement SkillElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//a[@href='/Home/Search?cat={skill}']//h3")));
                SkillElement.Click();
                Thread.Sleep(1000);

            }

        }
            //DisplayAllOnTheResultPage
            public void DisplayAllOnTheResultPage(IWebDriver driver1)
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
