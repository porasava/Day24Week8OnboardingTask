using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;
using Day24Week8OnboardingTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Security.Policy;
using System.Diagnostics.Metrics;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _009AccountRegisterStepDefinitions : CommonDriver
    {
        [Given(@"I navigate into Skill website successfully")]
        public void GivenINavigateIntoSkillWebsiteSuccessfully()
        {
            driver1 = new ChromeDriver();
            LogInPage loginPageObj = new LogInPage();
            loginPageObj.NavigateToSkillsWeb(driver1);
        }
        [When(@"I create a new account '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)', '([^']*)'")]
        public void WhenICreateANewAccount(string firstName, string lastName, string email, string password, string confirmPassword, string agree)
        {
            registrationPage registrationPageObj = new registrationPage();
            registrationPageObj.CreateANewAccount(driver1, firstName, lastName, email, password, confirmPassword, agree);
        }


        [Then(@"It should show error message Names must contain at least one letter")]
        public void ThenItShouldShowErrorMessageNamesMustContainAtLeastOneLetter()
        {
            registrationPage registrationPageObj = new registrationPage();
            registrationPageObj.ErrorMessageNamesMustContainAtLeastOneLetter(driver1);
            
        }

       
        [Then(@"It should show error message Lastnames must contain at least one letter")]
        public void ThenItShouldShowErrorMessageLastnamesMustContainAtLeastOneLetter()
        {
            registrationPage registrationPageObj = new registrationPage();
            registrationPageObj.ErrorMessageLastnamesMustContainAtLeastOneLetter(driver1);
          
        }

        
        [Then(@"It should show error message Please enter a valid email address.")]
        public void ThenItShouldShowErrorMessagePleaseEnterAValidEmailAddress()
        {
            registrationPage registrationPageObj = new registrationPage();
            registrationPageObj.ErrorMessagePleaseEnterAValidEmailAddress(driver1);
        }

        [Then(@"It should show error message Password must be at least (.*) letters")]
        public void ThenItShouldShowErrorMessagePasswordMustBeAtLeastLetters(int p0)
        {
            registrationPage registrationPageObj = new registrationPage();
            registrationPageObj.ErrorMessagePasswordMustBeAtLeastCharacters(driver1);
        }

        
        [Then(@"It should show error message Does not match password.")]
        public void ThenItShouldShowErrorMessageDoesNotMatchPassword()
        {
            registrationPage registrationPageObj = new registrationPage();
            registrationPageObj.ErrorMessageDoesNotMatchPassword(driver1);
        }

        [Then(@"It should show error message You must agree to the terms and conditions.")]
        public void ThenItShouldShowErrorMessageYouMustAgreeToTheTermsAndConditions()
        {
            registrationPage registrationPageObj = new registrationPage();
            registrationPageObj.ErrorMessageYouMustAgreeToTheTermsAndConditions(driver1);
        }

        [When(@"I loged into Skill website successfully with '([^']*)' and '([^']*)'")]
        public void WhenILogedIntoSkillWebsiteSuccessfullyWithAnd(string username, string password)
        {
            //LogInPage loginPageObj = new LogInPage();
            //loginPageObj.InputUsernameAndPassword(driver1, username, password);
            //loginPageObj.ClickOnLogin(driver1);
            driver1 = new ChromeDriver();
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.LogedIntoSkillWebsite(driver1, username, password);

        }

        [Then(@"user should sign in successfully")]
        public void ThenUserShouldSignInSuccessfully()
        {
            registrationPage registrationPageObj = new registrationPage();
            registrationPageObj.signInSuccessfully(driver1);
        }
    }
}
