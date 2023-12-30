using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _018HomePageSkillCatagoriesStepDefinitions : CommonDriver

    {
        [When(@"I click on '([^']*)' link")]
        public void WhenIClickOnLink(string skill)
        {
            //ClickOnLink
                HomePageskillCategory HomePageskillCategoryobj= new HomePageskillCategory();
            HomePageskillCategoryobj.ClickOnLink(driver1, skill);
        }

        [Then(@"It should display all skill on the result page")]
        public void ThenItShouldDisplayAllSkillOnTheResultPage()
        {
            
            HomePageskillCategory HomePageskillCategoryobj = new HomePageskillCategory();
            HomePageskillCategoryobj.DisplayAllOnTheResultPage(driver1);
        }

  
    }
}
