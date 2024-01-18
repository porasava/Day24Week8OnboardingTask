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
    public class AccountProfileSkillEdit
    {
        private readonly IWebDriver driver1;

        public AccountProfileSkillEdit(IWebDriver _driver)
        {
            driver1 = _driver;
        }
        By skillTab1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");
        By deleteError1 => By.XPath("/html/body/div[1]/div");

        private IWebElement skillTab => driver1.FindElement(skillTab1);
        private IWebElement editNewSkill => driver1.FindElement(By.XPath("//div[@id='account-profile-section']//table//td[3]/span[1]/i\r\n"));
        private IWebElement Skill => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private IWebElement updateSkillbutton => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        private IWebElement deleteError => driver1.FindElement(deleteError1);
        private IWebElement PopUpClose => driver1.FindElement(By.XPath("//a[@class='ns-close']"));

        //EditASkill
        public void EditASkill(string skill)
        {
            Wait.WaitToBeClickable(driver1, skillTab1, 5);
            skillTab.Click();
            Thread.Sleep(1000);
            editNewSkill.Click();
            Skill.Clear();
            Skill.SendKeys(skill);
            updateSkillbutton.Click();
        }

        //SkillShouldEditSuccessfully
        public void SkillShouldEditSuccessfully()
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, deleteError1, 5);
            Wait.ElementIsVisible(driver1, deleteError1, 5);
            string actualMessage = deleteError.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your skills";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }
    }
}
