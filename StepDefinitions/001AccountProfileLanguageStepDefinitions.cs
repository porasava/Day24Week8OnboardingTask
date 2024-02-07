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
    public class AccountProfileLanguageStepDefinitions 

    {
        private readonly IWebDriver driver1;
        private readonly LogInPage loginPageObj;
        private readonly AccountProfileLanguage AccountPageObj;

        public AccountProfileLanguageStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
            loginPageObj = new LogInPage(driver1);
            AccountPageObj = new AccountProfileLanguage(driver1);

        }
        [Given(@"I loged into Skill website successfully with '([^']*)' and '([^']*)'")]
        public void GivenILogedIntoSkillWebsiteSuccessfullyWithAnd( string username, string password)
        {
            loginPageObj.NavigateToSkillsWeb();
            loginPageObj.InputUsernameAndPassword( username, password);
            loginPageObj.ClickOnLogin();
        }

        [When(@"I navigate to account profile")]
        public void WhenINavigateToAccountProfile()
        {
            AccountPageObj.NavigateToAccountProfile();
        }

        [When(@"I add new Language with '([^']*)', and '([^']*)'")]
        public void WhenIAddNewLanguageWithAnd(string language, string languageLevel)
        {
            AccountPageObj.addNewLanguage( language, languageLevel);
        }

        [Then(@"User click on add Language")]
        public void ThenUserClickOnAddLanguage()
        {
            AccountPageObj.clickAddLanguage();
        }

        [Then(@"Language should be add successfully'([^']*)', and '([^']*)'")]
        public void ThenLanguageShouldBeAddSuccessfullyAnd(string language, string languageLevel)
        {
            AccountPageObj.languageShouldBeAddSuccessfully( language, languageLevel);
        }

        [Then(@"User click on cancel")]
        public void ThenUserClickOnCancel()
        {
            AccountPageObj.clickCancelLanguage();
        }

        [Then(@"Add Language button should be gone")]
        public void ThenAddLanguageButtonShouldBeGone()
        {
            AccountPageObj.checkAddLanguageButtonDisappear();
            
        }

        [When(@"I edit a Language with '([^']*)'")]
        public void WhenIEditALanguageWith(string language)
        {
            AccountPageObj.EditALanguage(language);
        }

        [Then(@"Language should be Edited successfully , '([^']*)'")]
        public void ThenLanguageShouldBeEditedSuccessfully(string languageEdit)
        {
            AccountPageObj.LanguageShouldBeEdited(languageEdit);
        }


        [Then(@"It should show error This language is already exist in your language list")]
        public void ThenItShouldShowErrorThisLanguageIsAlreadyExistInYourLanguageList()
        {
            AccountPageObj.ErrorThisLanguageIsAlreadyExistInYourLanguageList();
        }


        [Then(@"Remove Language")]
        public void ThenRemoveLanguage()
        {
            AccountPageObj.RemoveLanguage();
        }

        [When(@"I delete a Language '([^']*)'")]
        public void WhenIDeleteALanguage(string languageDelete)
        {
            AccountPageObj.DeleteALanguage(languageDelete);
        }

        [Then(@"Language should be remove successful")]
        public void ThenLanguageShouldBeRemoveSuccessful()
        {
            AccountPageObj.LanguageShouldBeRemoveSuccessful();
        }

        [Then(@"It should show error Please enter language and level")]
        public void ThenItShouldShowErrorPleaseEnterLanguageAndLevel()
        {
            AccountPageObj.ErrorPleaseenterlanguageandlevel();
        }

        [Then(@"It should show Error This language is already added to your language list\.")]
        public void ThenItShouldShowErrorThisLanguageIsAlreadyAddedToYourLanguageList_()
        {
            AccountPageObj.ErrorThisLanguageIsAlreadyAddedToYourLanguageList();
        }

        [When(@"I check existing Language")]
        public void WhenICheckExistingLanguage()
        {
            AccountPageObj.CheckExistingLanguage();
        }

    }
}
