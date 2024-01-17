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
    public class AccountProfileErrorLanguageStepDefinitions
    {        
        private readonly IWebDriver driver1;
        public AccountProfileErrorLanguageStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
        }
        [Then(@"It should show error Please enter language and level")]
        public void ThenItShouldShowErrorPleaseEnterLanguageAndLevel()
        {

            AccountProfileLanguageError AccountPageObj = new AccountProfileLanguageError(driver1);
            AccountPageObj.ErrorPleaseenterlanguageandlevel();
        }
        [Then(@"It should show error This language is already exist in your language list")]
        public void ThenItShouldShowErrorThisLanguageIsAlreadyExistInYourLanguageList()
        {
            AccountProfileLanguageError AccountPageObj = new AccountProfileLanguageError(driver1);
            AccountPageObj.ErrorThisLanguageIsAlreadyExistInYourLanguageList();
        }

        [Then(@"It should show Error This language is already added to your language list\.")]
        public void ThenItShouldShowErrorThisLanguageIsAlreadyAddedToYourLanguageList_()
        {
            AccountProfileLanguageError AccountPageObj = new AccountProfileLanguageError(driver1);
            AccountPageObj.ErrorThisLanguageIsAlreadyAddedToYourLanguageList();
        }
    }
}
