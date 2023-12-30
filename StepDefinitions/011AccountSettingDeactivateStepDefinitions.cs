using Day24Week8OnboardingTask.Utilities;
using Day24Week8OnboardingTask.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _011AccountSettingDeactivateStepDefinitions : CommonDriver
    {

        [When(@"I selected deactivate")]
        public void WhenISelectedDeactivate()
        {
            AccountSettingDeactivate accountSettingDeactivateobj = new AccountSettingDeactivate();
            accountSettingDeactivateobj.SelectedDeactivate(driver1);
        }

        [Then(@"It should show Deactivated account")]
        public void ThenItShouldShowDeactivatedAccount()
        {
            AccountSettingDeactivate accountSettingDeactivateobj = new AccountSettingDeactivate();
            accountSettingDeactivateobj.ShowDeactivatedAccount(driver1);
        }
    }
}
