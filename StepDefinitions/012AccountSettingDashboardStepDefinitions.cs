using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;
using Day24Week8OnboardingTask.Pages;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _012AccountSettingDashboardStepDefinitions: CommonDriver
    {

        [When(@"I click on Dashboard")]
        public void WhenIClickOnDashboard()
        {
            AccountSettingDashboard AccountSettingDashboardobj = new AccountSettingDashboard();
            AccountSettingDashboardobj.SelectedDashboard(driver1);
        }

        [Then(@"It should show notification page")]
        public void ThenItShouldShowNotificationPage()
        {
            AccountSettingDashboard AccountSettingDashboardobj = new AccountSettingDashboard();
            AccountSettingDashboardobj.notificationPage(driver1);

        }
    }
}
