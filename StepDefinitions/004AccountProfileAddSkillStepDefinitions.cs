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
        public AccountProfileAddSkillStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;

        }
     
        [When(@"I add a new Skill with '([^']*)', and '([^']*)'")]
        public void WhenIAddANewSkillWithAnd(string skill, string skillLevel)
        {
            AccountProfileAddSkill AccountPageObj = new AccountProfileAddSkill(driver1);
            AccountPageObj.AddANewSkill( skill, skillLevel);

        }

        [Then(@"It shoulsd show new Skill")]
        public void ThenItShoulsdShowNewSkill()
        {
            AccountProfileSkillError AccountPageObj = new AccountProfileSkillError(driver1);
            AccountPageObj.ShowNewSkill();
        }

        [Then(@"I delete a Skill '([^']*)'")]
        public void ThenIDeleteASkill(string skillDelete)
        {
            AccountProfileSkillDelete AccountPageObj = new AccountProfileSkillDelete(driver1);
            AccountPageObj.DeleteASkill( skillDelete);
        }

        [Then(@"Skill should be remove successfully")]
        public void ThenSkillShouldBeRemoveSuccessfully()
        {
            AccountProfileSkillDelete AccountPageObj = new AccountProfileSkillDelete(driver1);
            AccountPageObj.SkillShouldBeRemoveSuccessfully();
        }


        [Then(@"It shoulsd show error Please enter skill and experience level")]
        public void ThenItShoulsdShowErrorPleaseEnterSkillAndExperienceLevel()
        {

            AccountProfileSkillError AccountPageObj = new AccountProfileSkillError(driver1);
            AccountPageObj.ErrorPleaseEnterSkillAndExperienceLevel();
        }
    }
}
