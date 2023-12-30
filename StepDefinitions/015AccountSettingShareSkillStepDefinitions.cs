using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _015AccountSettingShareSkillStepDefinitions : CommonDriver
    {

        [When(@"I create a listing '([^']*)', '([^']*)', '([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void WhenICreateAListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.CreateAListing(driver1, title, description, category, subCategory, tags, skillExchange);
        }


        [Then(@"It should show error Title is required")]
        public void ThenItShouldShowErrorTitleIsRequired()
        {
            AccountSettingShareSkill AccountSettingShareSkillobj = new AccountSettingShareSkill();
            AccountSettingShareSkillobj.ErrorTitleIsRequired(driver1);
        }

        [Then(@"It should show error Description is required")]
        public void ThenItShouldShowErrorDescriptionIsRequired()
        {
            AccountSettingShareSkill AccountSettingShareSkillobj = new AccountSettingShareSkill();
            AccountSettingShareSkillobj.ErrorDescriptionIsRequired(driver1);
        }

        [Then(@"It should show error Category is required")]
        public void ThenItShouldShowErrorCategoryIsRequired()
        {
            AccountSettingShareSkill AccountSettingShareSkillobj = new AccountSettingShareSkill();
            AccountSettingShareSkillobj.ErrorCategoryIsRequired(driver1);
        }


        [Then(@"It should show error Tags are required")]
        public void ThenItShouldShowErrorTagsAreRequired()
        {
            AccountSettingShareSkill AccountSettingShareSkillobj = new AccountSettingShareSkill();
            AccountSettingShareSkillobj.ErrorTagsAreRequired(driver1);
        }


        [Then(@"It should show error Skill-Exchange are required")]
        public void ThenItShouldShowErrorSkill_ExchangeAreRequired()
        {
            AccountSettingShareSkill AccountSettingShareSkillobj = new AccountSettingShareSkill();
            AccountSettingShareSkillobj.ErrorSkillExchangeAreRequired(driver1);
        }
    }
}
