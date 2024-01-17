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
        private readonly AccountProfileSkillEdit AccountPageEditObj;
        public AccountProfileEditSkillStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
            AccountPageEditObj = new AccountProfileSkillEdit(driver1);
        }
        [When(@"I edit a skill with '([^']*)'")]
        public void WhenIEditASkillWith(string skill)
        {
            AccountPageEditObj.EditASkill(skill);
        }

        [Then(@"The skill should edit successfully")]
        public void ThenTheSkillShouldEditSuccessfully()
        {
            AccountPageEditObj.SkillShouldEditSuccessfully();
        }
    }
}
