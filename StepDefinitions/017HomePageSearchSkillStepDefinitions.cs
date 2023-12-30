using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _017HomePageSearchSkillStepDefinitions :CommonDriver
    {
        [When(@"I search a skill '([^']*)'")]
        public void WhenISearchASkill(string title)
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.SearchforAskill(driver1, title);
            
        }

        [Then(@"It should display skill on the result page")]
        public void ThenItShouldDisplaySkillOnTheResultPage()
        {
            HomePageSearchSkill HomePageSearchSkillobj = new HomePageSearchSkill();
            HomePageSearchSkillobj.DisplaySkillOnTheResultPage(driver1);
        }
    }
}
