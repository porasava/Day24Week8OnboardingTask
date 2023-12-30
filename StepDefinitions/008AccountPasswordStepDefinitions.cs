using System;
using TechTalk.SpecFlow;
using Day24Week8OnboardingTask.Utilities;
using Day24Week8OnboardingTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Security.Policy;
using System.Diagnostics.Metrics;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class AccountPasswordStepDefinitions : CommonDriver
    {
        [When(@"I navigate to password pop up")]
        public void WhenINavigateToPasswordPopUp()
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.NavigateToPasswordPopUp(driver1);
        }

        [When(@"I change password with '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenIChangePasswordWith(string currentPassword, string newPassword, string confirmPassword)
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.ChangePassword(driver1, currentPassword, newPassword, confirmPassword);
        }

        [Then(@"It should show pop up Password Changed Successfully")]
        public void ThenItShouldShowPopUpPasswordChangedSuccessfully()
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.ShowPasswordChanged(driver1);
        }

        [Then(@"I change password back with '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenIChangePasswordBackWith(string currentPassword2, string newPassword2, string confirmPassword2)
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.NavigateToPasswordPopUp(driver1);
            PasswordPageObj.ChangePassword(driver1, currentPassword2, newPassword2, confirmPassword2);
        }


        [Then(@"It should show pop up Password Verification Failed")]
        public void ThenItShouldShowPopUpPasswordVerificationFailed()
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.PasswordVerificationFailed(driver1);
        }

        [Then(@"It should show pop up Error while Updating Password details")]
        public void ThenItShouldShowPopUpErrorWhileUpdatingPasswordDetails()
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.ErrorWhileUpdatingPasswordDetails(driver1);
        }

        [Then(@"It should show pop up Error Please fill all the details before Submit")]
        public void ThenItShouldShowPopUpErrorPleaseFillAllTheDetailsBeforeSubmit()
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.PleaseFillAllTheDetailsBeforeSubmit(driver1);
        }

        [Then(@"It should show pop up Error Passwords required at least (.*) characters")]
        public void ThenItShouldShowPopUpErrorPasswordsRequiredAtLeastCharacters(int p0)
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.ErrorPasswordsRequiredAtLeastCharacters(driver1);
        }

        [Then(@"It should show pop up Error Passwords does not match")]
        public void ThenItShouldShowPopUpErrorPasswordsDoesNotMatch()
        {
            PasswordPopUp PasswordPageObj = new PasswordPopUp();
            PasswordPageObj.ErrorPasswordsDoesNotMatch(driver1);
        }

    }
}
