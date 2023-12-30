using Day24Week8OnboardingTask.Utilities;
using Day24Week8OnboardingTask.Pages;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _014AccountSettingManageRequestStepDefinitions: CommonDriver
    {
        [Given(@"I logout from Skill website")]
        public void GivenILogoutFromSkillWebsite()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.LogoutFromSkillWebsite(driver1);
        }

        [When(@"I search for a listing '([^']*)' and send request")]
        public void WhenISearchForAListingAndSendRequest(string title)
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.SearchforAskill(driver1, title);
            AccountSettingManageRequestObj.SearchForAListingAndSendRequest(driver1,title);
        }

        [When(@"I logout from Skill website")]
        public void WhenILogoutFromSkillWebsite()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.LogoutFromSkillWebsite(driver1);
        }

        [When(@"I click on Manage request dropdown and select Received requests")]
        public void WhenIClickOnManageRequestDropdownAndSelectReceivedRequests()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ManageRequestDropdownAndSelectReceivedRequests(driver1);
        }

        [When(@"I click accept")]
        public void WhenIClickAccept()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ClickAccept(driver1);
        }

        [Then(@"the listing status should change to complete on receive request")]
        public void ThenTheListingStatusShouldChangeToCompleteOnReceiveRequest()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.TheListingStatusShouldChangeToCompleteOnReceiveRequest(driver1);
        }

        [When(@"I click decline")]
        public void WhenIClickDecline()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ClickDecline(driver1);
        }

        [When(@"I click completed")]
        public void WhenIClickCompleted()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ClickCompleted(driver1);
        }

        [Then(@"the listing status should change to declined")]
        public void ThenTheListingStatusShouldChangeToDeclined()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ListingStatusShouldChangeToDeclined(driver1);
        }


        [When(@"I click on Manage request dropdown and select send Requests")]
        public void WhenIClickOnManageRequestDropdownAndSelectSendRequests()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ManageRequestDropdownAndSelectSelectSendRequests(driver1);
        }
       

        [Then(@"the listing status should change to review")]
        public void ThenTheListingStatusShouldChangeToReview()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ListingStatusShouldChangeToReview(driver1);
            
        }


        [When(@"I click review")]
        public void WhenIClickReview()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ClickReview(driver1);
        }

        [Then(@"this listing should show review rate successful")]
        public void ThenThisListingShouldShowReviewRateSuccessful()
        {
            AccountSettingManageRequest AccountSettingManageRequestObj = new AccountSettingManageRequest();
            AccountSettingManageRequestObj.ListingShouldShowReviewRateSuccessful(driver1);
        }


    }
}
