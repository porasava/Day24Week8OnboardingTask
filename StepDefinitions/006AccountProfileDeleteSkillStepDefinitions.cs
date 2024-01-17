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
        AccountProfileSkillDelete AccountPageDeleteObj;
        public AccountProfileDeleteSkillStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
            AccountPageDeleteObj = new AccountProfileSkillDelete(driver1);
        }
        [When(@"I delete a skill with '([^']*)'")]
        public void WhenIDeleteASkillWith(string skillDelete)
        {
            AccountPageDeleteObj.DeleteASkill(skillDelete);
        }

        [Then(@"The skill should delete successfully")]
        public void ThenTheSkillShouldDeleteSuccessfully()
        {
            AccountPageDeleteObj.SkillShouldBeRemoveSuccessfully();
        }

    }
}
