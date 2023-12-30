using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _013AccountSettingListingStepDefinitions: CommonDriver
    {
        [Given(@"I create a listing '([^']*)', '([^']*)', '([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void GivenICreateAListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.CreateAListing(driver1, title, description, category, subCategory, tags, skillExchange);
        }

        [When(@"I navigate to Manage listing page")]
        public void WhenINavigateToManageListingPage()
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.NavigateToManageListingPage(driver1);
           
        }

        [When(@"I edit listing '([^']*)', '([^']*)', '([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void WhenIEditListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.EditAListing(driver1, title, description, category, subCategory, tags, skillExchange);
        }


        [Then(@"It should show the listing update on the listing detail page '([^']*)', '([^']*)'")]
        public void ThenItShouldShowTheListingUpdateOnTheListingDetailPage(string title, string description)
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.ListingUpdateOnTheListingDetailPage(driver1, title, description);
        }

        [When(@"I click on see listing")]
        public void WhenIClickOnSeeListing()
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.ClickOnSeeListing(driver1);
        }


        [Then(@"It should show the listing on the listing detail page '([^']*)', '([^']*)', '([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void ThenItShouldShowTheListingOnTheListingDetailPage(string title, string description, string Category, string SubCategory, string SkillExchange, string LocationType)
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.ShowTheListingOnTheListingDetailPage(driver1, title, description, Category, SubCategory, SkillExchange, LocationType);
        }





        [When(@"I click on Deactivate listing")]
        public void WhenIClickOnDeactivateListing()
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.ClickOnDeactivateListing(driver1);
        }

        [Then(@"It should show Service has been deactivated")]
        public void ThenItShouldShowServiceHasBeenDeactivated()
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.ShowServiceHasBeenDeactivated(driver1);
        }

        [When(@"I click on activate listing")]
        public void WhenIClickOnActivateListing()
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.ClickOnDeactivateListing(driver1);
        }

        [Then(@"It should show Service has been activated")]
        public void ThenItShouldShowServiceHasBeenActivated()
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.ServiceHasBeenActivated(driver1);
        }

        [When(@"I click on delete listing '([^']*)'")]
        public void WhenIClickOnDeleteListing(string title)
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.DeleteListing(driver1,title);
        }

        [Then(@"The listing should be delete successfully")]
        public void ThenTheListingShouldBeDeleteSuccessfully()
        {
            AccountSettingListing AccountSettingListingobj = new AccountSettingListing();
            AccountSettingListingobj.ListingShouldBeDeleteSuccessfully(driver1);
        }
    }
}
