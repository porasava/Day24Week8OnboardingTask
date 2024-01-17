using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;
using Day24Week8OnboardingTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Security.Policy;
using System.Diagnostics.Metrics;
using OpenQA.Selenium;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class AccountProfileAddLanguageStepDefinitions 

    {
        private readonly IWebDriver driver1;
        public AccountProfileAddLanguageStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;

        }
        [Given(@"I loged into Skill website successfully with '([^']*)' and '([^']*)'")]
        public void GivenILogedIntoSkillWebsiteSuccessfullyWithAnd( string username, string password)
        {
            LogInPage loginPageObj = new LogInPage(driver1);
            loginPageObj.NavigateToSkillsWeb();
            loginPageObj.InputUsernameAndPassword( username, password);
            loginPageObj.ClickOnLogin();
        }

        [When(@"I navigate to account profile")]
        public void WhenINavigateToAccountProfile()
        {
            AccountProfileLanguageAdd AccountPageObj = new AccountProfileLanguageAdd(driver1);
            AccountPageObj.NavigateToAccountProfile();
        }


        [When(@"I add new Language with '([^']*)', and '([^']*)'")]
        public void WhenIAddNewLanguageWithAnd(string language, string languageLevel)
        {
            AccountProfileLanguageAdd AccountPageObj = new AccountProfileLanguageAdd(driver1);
            AccountPageObj.addNewLanguage( language, languageLevel);
        }

        [Then(@"User click on add Language")]
        public void ThenUserClickOnAddLanguage()
        {
            AccountProfileLanguageAdd AccountPageObj = new AccountProfileLanguageAdd(driver1);
            AccountPageObj.clickAddLanguage();
        }

        [Then(@"Language should be add successfully'([^']*)', and '([^']*)'")]
        public void ThenLanguageShouldBeAddSuccessfullyAnd(string language, string languageLevel)
        {
            AccountProfileLanguageError AccountPageObj = new AccountProfileLanguageError(driver1);
            AccountPageObj.languageShouldBeAddSuccessfully( language, languageLevel);
        }

        [Then(@"User click on cancel")]
        public void ThenUserClickOnCancel()
        {
            AccountProfileLanguageAdd AccountPageObj = new AccountProfileLanguageAdd(driver1);
            AccountPageObj.clickCancelLanguage();
        }

        [Then(@"Add Language button should be gone")]
        public void ThenAddLanguageButtonShouldBeGone()
        {
            AccountProfileLanguageAdd AccountPageObj = new AccountProfileLanguageAdd(driver1);
            AccountPageObj.checkAddLanguageButtonDisappear();
            
        }

    }
}
