using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class AccountProfileEditSkillStepDefinitions
    {
        private readonly IWebDriver driver1;
        public AccountProfileEditSkillStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
        }
        [When(@"I edit a skill with '([^']*)'")]
        public void WhenIEditASkillWith(string skill)
        {
            AccountProfileSkillEdit AccountPageObj = new AccountProfileSkillEdit(driver1);
            AccountPageObj.EditASkill(skill);
        }

        [Then(@"The skill should edit successfully")]
        public void ThenTheSkillShouldEditSuccessfully()
        {
            AccountProfileSkillEdit AccountPageObj = new AccountProfileSkillEdit(driver1);
            AccountPageObj.SkillShouldEditSuccessfully();
        }
    }
}
