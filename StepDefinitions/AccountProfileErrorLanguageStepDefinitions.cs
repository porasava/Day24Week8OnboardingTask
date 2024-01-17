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
        private readonly AccountProfileLanguageError AccountPageErrorObj;
        public AccountProfileErrorLanguageStepDefinitions(CommonDriver commonDriver)
        {
            driver1 = commonDriver.Driver;
            AccountPageErrorObj = new AccountProfileLanguageError(driver1);
        }
        [Then(@"It should show error Please enter language and level")]
        public void ThenItShouldShowErrorPleaseEnterLanguageAndLevel()
        {
            AccountPageErrorObj.ErrorPleaseenterlanguageandlevel();
        }
        [Then(@"It should show error This language is already exist in your language list")]
        public void ThenItShouldShowErrorThisLanguageIsAlreadyExistInYourLanguageList()
        {
            AccountPageErrorObj.ErrorThisLanguageIsAlreadyExistInYourLanguageList();
        }

        [Then(@"It should show Error This language is already added to your language list\.")]
        public void ThenItShouldShowErrorThisLanguageIsAlreadyAddedToYourLanguageList_()
        {            
            AccountPageErrorObj.ErrorThisLanguageIsAlreadyAddedToYourLanguageList();
        }
    }
}
