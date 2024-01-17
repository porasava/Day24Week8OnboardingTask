using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _002AccountProfileEditLanguageStepDefinitions
    {
        private readonly IWebDriver driver1;
        private readonly AccountProfileLanguageEdit AccountPageEditObj;
        private readonly AccountProfileLanguageError AccountPageErrorObj;

        public _002AccountProfileEditLanguageStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
            AccountPageEditObj = new AccountProfileLanguageEdit(driver1);
            AccountPageErrorObj = new AccountProfileLanguageError(driver1);
        }

        [When(@"I edit a Language with '([^']*)'")]
        public void WhenIEditALanguageWith(string language)
        {
            AccountPageEditObj.EditALanguage(language);
        }

        [Then(@"Language should be Edited successfully , '([^']*)'")]
        public void ThenLanguageShouldBeEditedSuccessfully(string languageEdit)
        {
            AccountPageEditObj.LanguageShouldBeEdited(languageEdit);
        }

        [Then(@"It should show Error This language is already exist in your language list")]
        public void ThenItShouldShowErrorThisLanguageIsAlreadyExistInYourLanguageList()
        {
            AccountPageErrorObj.ErrorThisLanguageIsAlreadyExistInYourLanguageList();
        }

    }
}
