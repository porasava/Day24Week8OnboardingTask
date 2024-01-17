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
    public class AccountProfileAddSkill
    {
        private readonly IWebDriver driver1;

        public AccountProfileAddSkill(IWebDriver _driver)
        {
            driver1 = _driver;
        }
        By skillTab1 => By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");

        private IWebElement skillTab => driver1.FindElement(skillTab1);
        By addNewSkill1 => By.XPath("//div[@class='ui teal button' and text()='Add New']");

        private IWebElement addNewSkill => driver1.FindElement(addNewSkill1);
        private IWebElement Skill => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private IWebElement skillLeveltext => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private IWebElement addSkillbutton => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        //AddANewSkill
        public void AddANewSkill(string skill, string skillLevel)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.WaitToBeClickable(driver1, skillTab1, 5);
            skillTab.Click();
            Wait.WaitToBeClickable(driver1, addNewSkill1, 5);
            addNewSkill.Click();
            Skill.SendKeys(skill);
            skillLeveltext.Click();
            skillLeveltext.SendKeys(skillLevel);
            addSkillbutton.Click();
        }
    }
}
