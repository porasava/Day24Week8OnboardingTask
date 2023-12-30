using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _010AccountSettingPasswordStepDefinitions: CommonDriver
    {
        [When(@"I navigate to account settings")]
        public void WhenINavigateToAccountSettings()
        {
            accountSettingPassword accountSettingPasswordPageObj = new accountSettingPassword();
            accountSettingPasswordPageObj.NavigateToAccountSettings(driver1);
        }

        [When(@"Edit password in the account setting page with '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenEditPasswordInTheAccountSettingPageWith(string currentPassword, string newPassword, string confirmPassword)
        {
            accountSettingPassword accountSettingPasswordPageObj = new accountSettingPassword();
            accountSettingPasswordPageObj.EditPasswordInTheAccountSettingPage(driver1, currentPassword, newPassword,confirmPassword);
            
        }

        [Then(@"I change password back with '([^']*)', '([^']*)', '([^']*)' in the account setting page")]
        public void ThenIChangePasswordBackWithInTheAccountSettingPage(string currentPassword, string newPassword, string confirmPassword)
        {
            accountSettingPassword accountSettingPasswordPageObj = new accountSettingPassword();
            accountSettingPasswordPageObj.refreshPasswordpage(driver1);
            accountSettingPasswordPageObj.EditPasswordInTheAccountSettingPage(driver1, currentPassword, newPassword, confirmPassword);
        }
    }
}
