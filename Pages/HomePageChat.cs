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

namespace Day24Week8OnboardingTask.Pages
{
    public class HomePageChat
    {
        //ChatWithPerson
        public void ChatWithPerson(IWebDriver driver1, string chat)
        {

                WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
                IWebElement selectAskilPage = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//p[@class='row-padded']")));
                selectAskilPage.Click();
                Thread.Sleep(1000);
                IWebElement chatOnSkillPage = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//a[@class='ui teal button']")));
                chatOnSkillPage.Click();
                Thread.Sleep(1000);
                IWebElement chatBox = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//input[@id='chatTextBox']")));
                chatBox.SendKeys(chat);
                Thread.Sleep(1000);
                IWebElement sendatextbutton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[@id='btnSend']")));
                sendatextbutton.SendKeys(chat);

        }


        //CkickOnChat
        public void CkickOnChat(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement GoToChatPage = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//a[@href='/Home/Message']")));
            GoToChatPage.Click();
            Thread.Sleep(1000);
            IWebElement clickonChat = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[@id='chatList']//div[2]//div[2]//div[1]")));
            clickonChat.Click();
        }



        //ChatNotificationFromPerson
        public void ChatNotificationFromPerson(IWebDriver driver1)
        {

            Wait.ElementIsVisible(driver1, "Xpath", "//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/span[1]/div[2]/div[1]/div[1]/span[1]", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/span[1]/div[2]/div[1]/div[1]/span[1]"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Hi I am Tananya2";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);



        }



    }
}
