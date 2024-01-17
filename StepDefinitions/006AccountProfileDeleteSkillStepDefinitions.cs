using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class AccountProfileDeleteSkillStepDefinitions
    {
        private readonly IWebDriver driver1;
        public AccountProfileDeleteSkillStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
        }
        [When(@"I delete a skill with '([^']*)'")]
        public void WhenIDeleteASkillWith(string skillDelete)
        {
            AccountProfileSkillDelete AccountPageObj = new AccountProfileSkillDelete(driver1);
            AccountPageObj.DeleteASkill(skillDelete);
        }

        [Then(@"The skill should delete successfully")]
        public void ThenTheSkillShouldDeleteSuccessfully()
        {
            AccountProfileSkillDelete AccountPageObj = new AccountProfileSkillDelete(driver1);
            AccountPageObj.SkillShouldBeRemoveSuccessfully();
        }

    }
}
