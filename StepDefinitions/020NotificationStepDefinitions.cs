using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _020NotificationStepDefinitions :CommonDriver
    {
        [When(@"User click on Notification on the top right of the page")]
        public void WhenUserClickOnNotificationOnTheTopRightOfThePage()
        {
            Notification notificationobj = new Notification();
            notificationobj.ClickOnNotification(driver1); 
        }

        [When(@"User click mark all read link")]
        public void WhenUserClickMarkAllReadLink()
        {
            Notification notificationobj = new Notification();
            notificationobj.UserClickMarkAllReadLink(driver1);
        }

        //[Then(@"all Notification message should mark all read")]
        //public void ThenAllNotificationMessageShouldMarkAllRead()
        //{
        //    throw new PendingStepException();
        //}

        [When(@"User click see all link")]
        public void WhenUserClickSeeAllLink()
        {
            Notification notificationobj = new Notification();
            notificationobj.ClickSeeAllLink(driver1);
        }

        [When(@"User click select all link")]
        public void WhenUserClickSelectAllLink()
        {
            Notification notificationobj = new Notification();
            notificationobj.SelectAllLink(driver1);
        }

        [Then(@"all message should be checked")]
        public void ThenAllMessageShouldBeChecked()
        {
           
            Notification notificationobj = new Notification();
            notificationobj.AllMessageShouldBeChecked(driver1);
        }

        [When(@"User click unselect all link")]
        public void WhenUserClickUnselectAllLink()
        {
            Notification notificationobj = new Notification();
            notificationobj.ClickUnselectAllLink(driver1);
        }


        [Then(@"All messages should be unchecked")]
        public void ThenAllMessagesShouldBeUnchecked()
        {
            Notification notificationobj = new Notification();
            notificationobj.AllMessagesShouldBeUnchecked(driver1);
        }

        [When(@"User click delete a message")]
        public void WhenUserClickDeleteAMessage()
        {
            Notification notificationobj = new Notification();
            notificationobj.UserClickDeleteAMessage(driver1);
        }

        [Then(@"It should delete one notification from the notification page")]
        public void ThenItShouldDeleteOneNotificationFromTheNotificationPage()
        {
            Notification notificationobj = new Notification();
            notificationobj.DeleteOneNotification(driver1);
        }

        [When(@"User select a message")]
        public void WhenUserSelectAMessage()
        {
            Notification notificationobj = new Notification();
            notificationobj.UserSelectAMessage(driver1);
        }

        [Then(@"It should show Received Requests page")]
        public void ThenItShouldShowReceivedRequestsPage()
        {
            
            Notification notificationobj = new Notification();
            notificationobj.ShowReceivedRequestsPage(driver1);
        }
    }
}
