using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class AccountProfileAddSkillStepDefinitions
    {
        private readonly IWebDriver driver1;
        private readonly AccountProfileAddSkill AccountPageAddObj;
        private readonly AccountProfileSkillError AccountPageErrorObj;
        private readonly AccountProfileSkillDelete AccountPageDeleteObj;
        public AccountProfileAddSkillStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
            AccountPageAddObj = new AccountProfileAddSkill(driver1);
            AccountPageErrorObj = new AccountProfileSkillError(driver1);
            AccountPageDeleteObj = new AccountProfileSkillDelete(driver1);
        }
     
        [When(@"I add a new Skill with '([^']*)', and '([^']*)'")]
        public void WhenIAddANewSkillWithAnd(string skill, string skillLevel)
        {
            AccountPageAddObj.AddANewSkill( skill, skillLevel);
        }

        [Then(@"It shoulsd show new Skill")]
        public void ThenItShoulsdShowNewSkill()
        {
            AccountPageErrorObj.ShowNewSkill();
        }

        [Then(@"I delete a Skill '([^']*)'")]
        public void ThenIDeleteASkill(string skillDelete)
        {
            AccountPageDeleteObj.DeleteASkill( skillDelete);
        }

        [Then(@"Skill should be remove successfully")]
        public void ThenSkillShouldBeRemoveSuccessfully()
        {
            AccountPageDeleteObj.SkillShouldBeRemoveSuccessfully();
        }

        [Then(@"It shoulsd show error Please enter skill and experience level")]
        public void ThenItShoulsdShowErrorPleaseEnterSkillAndExperienceLevel()
        {
            AccountPageErrorObj.ErrorPleaseEnterSkillAndExperienceLevel();
        }
    }
}
