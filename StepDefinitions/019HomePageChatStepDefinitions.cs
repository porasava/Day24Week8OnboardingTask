using Day24Week8OnboardingTask.Pages;
using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class _019HomePageChatStepDefinitions: CommonDriver
    {
        [When(@"I try to chat with person '([^']*)','([^']*)'")]
        public void WhenITryToChatWithPerson(string title, string chat)
        {
            AccountSettingManageRequest AccountSettingManageRequestObj= new AccountSettingManageRequest();
            AccountSettingManageRequestObj.SearchforAskill(driver1,title);
            HomePageChat HomePageChatObj = new HomePageChat();
            HomePageChatObj.ChatWithPerson(driver1, chat);

        }


        [When(@"I ckick on chat")]
        public void WhenICkickOnChat()
        {            
            HomePageChat HomePageChatObj = new HomePageChat();
            HomePageChatObj.CkickOnChat(driver1);
        }




        [Then(@"User should see chat notification from person")]
        public void ThenUserShouldSeeChatNotificationFromPerson()
        {
            HomePageChat HomePageChatObj = new HomePageChat();
            HomePageChatObj.ChatNotificationFromPerson(driver1);
        }
    }
}
