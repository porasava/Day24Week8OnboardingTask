using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using System.Numerics;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.Pages
{
    public class AccountSettingManageRequest
    {

        //LogoutFromSkillWebsite
        public void LogoutFromSkillWebsite(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement logoutButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='ui green basic button']")));
            logoutButton.Click();
            Thread.Sleep(1000);
            driver1.Quit();
        }
        //SearchforAskill
        public void SearchforAskill(IWebDriver driver1, string title)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement searchSkillButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ui secondary menu']//input[@placeholder='Search skills']")));
            searchSkillButton.SendKeys(title);
            searchSkillButton.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
          
        }

        //SearchForAListingAndSendRequest
        public void SearchForAListingAndSendRequest(IWebDriver driver1, string title)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Thread.Sleep(1000);
            IWebElement Listing = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//p[@class='row-padded']")));
            Listing.Click();
            Thread.Sleep(1000);
            IWebElement requestSkillTrade = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'button')]")));
            requestSkillTrade.Click();
            IWebElement ConfirmrequestSkillTrade = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[4]/div/div[3]/button[1]")));
            ConfirmrequestSkillTrade.Click();


        }

        //ManageRequestDropdownAndSelectReceivedRequests
        public void ManageRequestDropdownAndSelectReceivedRequests(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement manageRequestsElement = driver1.FindElement(By.XPath("//div[contains(text(), 'Manage Requests')]"));
            Actions action = new Actions(driver1);
            action.MoveToElement(manageRequestsElement).Perform();
            IWebElement ReceivedRequestsDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Received Requests']")));
            ReceivedRequestsDropdown.Click();
            Thread.Sleep(1000);

        }

        //ClickAccept
        public void ClickAccept(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement acceptButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='ui primary basic button']")));
            acceptButton.Click();
            Thread.Sleep(1000);

        }


        public void TheListingStatusShouldChangeToCompleteOnReceiveRequest(IWebDriver driver1)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Service has been updated";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);
            IWebElement actionText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@type='button']")));
            string actionactualText = actionText.Text.Trim();
            // The static part of the message you expect
            Assert.That(actionactualText.Contains("Complete"), $"location of element does not match expected.");
        }

        //ListingStatusShouldChangeToDeclined
        public void ListingStatusShouldChangeToDeclined(IWebDriver driver1)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Service has been updated";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }


        //ManageRequestDropdownAndSelectSelectSendRequests
        public void ClickDecline(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement declineButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='ui negative basic button']")));
            declineButton.Click();
            Thread.Sleep(1000);

        }

        //ClickCompleted
        public void ClickCompleted(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement completeButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@type='button']")));
            completeButton.Click();
            Thread.Sleep(1000);

        }

        //TheListingStatusShouldChangeToCompleteOnReceiveRequest
        public void ChangeToCompleteOnReceiveRequest(IWebDriver driver1)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Service has been updated";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);
            IWebElement actionText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@type='button']")));
            string actionactualText = actionText.Text.Trim();
            // The static part of the message you expect
            Assert.That(actionactualText.Contains("Complete"), $"location of element does not match expected.");
        }



        //ManageRequestDropdownAndSelectSelectSendRequests
        public void ManageRequestDropdownAndSelectSelectSendRequests(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));

            IWebElement manageRequestsElement = driver1.FindElement(By.XPath("//div[contains(text(), 'Manage Requests')]"));
            Actions action = new Actions(driver1);
            action.MoveToElement(manageRequestsElement).Perform();


            //IWebElement manageRequestButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ui dropdown link item active visible']")));
            //manageRequestButton.Click();
            IWebElement sendRequestButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Sent Requests']")));
            sendRequestButton.Click();
            Thread.Sleep(1000);

        }


        //ListingStatusShouldChangeToReview
        public void ListingStatusShouldChangeToReview(IWebDriver driver1)
        {
           Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement ReviewButton = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string actualReviewButton = ReviewButton.Text.Trim();

            // The static part of the message you expect
            string expectedReviewButtonStaticPart = "Request has been updated";

            // Assert that the actual message contains the expected static part
            Assert.That(actualReviewButton.Contains(expectedReviewButtonStaticPart),
                $"The actual text '{actualReviewButton}' does not contain the expected text '{expectedReviewButtonStaticPart}'.");
            Thread.Sleep(1000);
            IWebElement actionText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@type='button']")));
            string actionactualText = actionText.Text.Trim();
            // The static part of the message you expect
            Assert.That(actionactualText.Contains("Review"), $"location of element does not match expected.");

        }

        //ClickReview
        public void ClickReview(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement reviewButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//tbody/tr[1]/td[8]/button[1]")));
            reviewButton.Click();
            Thread.Sleep(2000);
           // reviewButton.Click();
            IWebElement SellerRate = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='communicationRating']//i[5]")));
            SellerRate.Click();
            IWebElement ServiceRate = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='serviceRating']//i[5]")));
            ServiceRate.Click();
            IWebElement reccomenceRate = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='recommendRating']//i[5]")));
            reccomenceRate.Click();
            ////div[@class='ui teal button']
            IWebElement save = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ui teal button']")));
            save.Click();
            Thread.Sleep(1000);

        }

        //ListingShouldShowReviewRateSuccessful
        public void ListingShouldShowReviewRateSuccessful(IWebDriver driver1)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement rateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string actualrateCheck = rateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedrateCheckStaticPart = "Rating added, thank you!";

            // Assert that the actual message contains the expected static part
            Assert.That(actualrateCheck.Contains(expectedrateCheckStaticPart),
                $"The actual text '{actualrateCheck}' does not contain the expected text '{expectedrateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }



        [AfterScenario]
        public void AfterScenario(IWebDriver driver1)
        {
            driver1.Quit();
        }
    }
}
