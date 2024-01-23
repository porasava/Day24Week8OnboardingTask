using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class AccountProfileSkillStepDefinitions
    {
        private readonly IWebDriver driver1;
        private readonly AccountProfileSkill AccountPageObj;

        public AccountProfileSkillStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
            AccountPageObj = new AccountProfileSkill(driver1);

        }
        [When(@"I navigate to account profile Skill")]
        public void WhenINavigateToAccountProfileSkill()
        {
            AccountPageObj.NavigateToAccountProfileSkill();
        }

        [When(@"I add a new Skill with '([^']*)', and '([^']*)'")]
        public void WhenIAddANewSkillWithAnd(string skill, string skillLevel)
        {
            AccountPageObj.AddANewSkill( skill, skillLevel);
        }

        [Then(@"It shoulsd show new Skill")]
        public void ThenItShoulsdShowNewSkill()
        {
            AccountPageObj.ShowNewSkill();
        }

        [Then(@"I delete a Skill '([^']*)'")]
        public void ThenIDeleteASkill(string skillDelete)
        {
            AccountPageObj.DeleteASkill( skillDelete);
        }

        [Then(@"Skill should be remove successfully")]
        public void ThenSkillShouldBeRemoveSuccessfully()
        {
            AccountPageObj.SkillShouldBeRemoveSuccessfully();
        }

        [Then(@"It shoulsd show error Please enter skill and experience level")]
        public void ThenItShoulsdShowErrorPleaseEnterSkillAndExperienceLevel()
        {
            AccountPageObj.ErrorPleaseEnterSkillAndExperienceLevel();
        }

        [When(@"I edit a skill with '([^']*)'")]
        public void WhenIEditASkillWith(string skill)
        {
            AccountPageObj.EditASkill(skill);
        }

        [Then(@"The skill should edit successfully")]
        public void ThenTheSkillShouldEditSuccessfully()
        {
            AccountPageObj.SkillShouldEditSuccessfully();
        }

        [When(@"I delete a skill with '([^']*)'")]
        public void WhenIDeleteASkillWith(string skillDelete)
        {
            AccountPageObj.DeleteASkill(skillDelete);
        }

        [Then(@"The skill should delete successfully")]
        public void ThenTheSkillShouldDeleteSuccessfully()
        {
            AccountPageObj.SkillShouldBeRemoveSuccessfully();
        }
        [When(@"I check existing Skill")]
        public void WhenICheckExistingSkill()
        {
            AccountPageObj.checkExistingSkill();
        }

    }
}
