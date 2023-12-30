using System;
using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class AccountSignInStepDefinitions : CommonDriver
    {
        [Given(@"I navigate to Skills website")]
        public void GivenINavigateToSkillsWebsite()
        {
            driver1 = new ChromeDriver();
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.NavigateToSkillsWeb(driver1);
        }


        [When(@"I put '([^']*)' and '([^']*)'")]
        public void WhenIPutAnd(string username, string password)
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.InputUsernameAndPassword(driver1,username, password);
        }

        [Then(@"It should show Error Confirm Your Email")]
        public void ThenItShouldShowErrorConfirmYourEmail()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.ClickOnLogin(driver1);
            loginPageObj.ConfirmYourEmailError(driver1);
           
        }

        [Then(@"It should show error wrong email or password")]
        public void ThenItShouldShowErrorWrongEmailOrPassword()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.ClickOnLogin(driver1);
            loginPageObj.ErrorWrongEmailOrPassword(driver1);
            
        }

        [Then(@"It should show error Password must be at least (.*) characters")]
        public void ThenItShouldShowErrorPasswordMustBeAtLeastCharacters(int p0)
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.ErrorPasswordMustBeAtLeastCharacters(driver1);
        }

      
        [When(@"I input '([^']*)'")]
        public void WhenIInput(string username)
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.InputEmail(driver1, username);
            
        }

        [When(@"I click send varification email")]
        public void WhenIClickSendVarificationEmail()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.SendVarificationEmail(driver1);
        }

  
        [When(@"I Click forgot password")]
        public void WhenIClickForgotPassword()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.ForgotPassword(driver1);
        }

 
        [Then(@"It should show Please check your email to reset password and A recovery link has been sent to your inbox\.")]
        public void ThenItShouldShowPleaseCheckYourEmailToResetPasswordAndARecoveryLinkHasBeenSentToYourInbox_()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.LinkHasBeenSentToYourInbox(driver1);
        }


        [Then(@"It should show error field cannot be empty")]
        public void ThenItShouldShowErrorFieldCannotBeEmpty()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.FieldCannotBeEmpty(driver1);
        }

        [When(@"I click on Join link")]
        public void WhenIClickOnJoinLink()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.WhenIClickOnJoinLink(driver1);
        }

        [Then(@"It should directly go to the registration pop-up")]
        public void ThenItShouldDirectlyGoToTheRegistrationPop_Up()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.GoToTheRegistrationPopUp(driver1);
  
        }

        [Then(@"I loged into Skill website successfully and go to Account Profile page")]
        public void ThenILogedIntoSkillWebsiteSuccessfullyAndGoToAccountProfilePage()
        {
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.ClickOnLogin(driver1);

        }

        [Then(@"It should show error Please enter valid email address")]
        public void ThenItShouldShowErrorPleaseEnterValidEmailAddress()
        {
            
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.ValidateErrorvalidemailaddress(driver1);
           
        }




        [AfterScenario]
        public void AfterScenario()
        {
            driver1.Quit();
        }

    }
}
