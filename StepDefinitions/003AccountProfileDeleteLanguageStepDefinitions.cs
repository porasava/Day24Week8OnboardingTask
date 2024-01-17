using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _003AccountProfileDeleteLanguageStepDefinitions
    {
        private readonly IWebDriver driver1;

        public _003AccountProfileDeleteLanguageStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
        }
        [Then(@"Remove Language")]
        public void ThenRemoveLanguage()
        {
            AccountProfileLanguageDelete AccountPageObj = new AccountProfileLanguageDelete(driver1);
            AccountPageObj.RemoveLanguage();
        }

        [When(@"I delete a Language '([^']*)'")]
        public void WhenIDeleteALanguage(string languageDelete)
        {
            AccountProfileLanguageDelete AccountPageObj = new AccountProfileLanguageDelete(driver1);
            AccountPageObj.DeleteALanguage(languageDelete);
        }

        [Then(@"Language should be remove successful")]
        public void ThenLanguageShouldBeRemoveSuccessful()
        {
            AccountProfileLanguageDelete AccountPageObj = new AccountProfileLanguageDelete(driver1);
            AccountPageObj.LanguageShouldBeRemoveSuccessful();
        }


    }
}
