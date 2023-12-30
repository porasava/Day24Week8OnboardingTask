using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace Day24Week8OnboardingTask.Pages
{
    public class Notification
    {
        // ClickOnNotification
        public void ClickOnNotification(IWebDriver driver1)
        {
            Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement Notification = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"/html/body/div[1]/div/div[1]/div[2]/div/div")));
            Notification.Click();
            Thread.Sleep(1000);
        }



        //UserClickMarkAllReadLink
        public void UserClickMarkAllReadLink(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement markAllRead = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[@class='ui menu link transition visible']//span//div//div//div[@class='ui link item']//a")));
            markAllRead.Click();
            Thread.Sleep(1000);

        }



        //AllNotificationMessageShouldMarkAllRead




        //ClickSeeAllLink
        public void ClickSeeAllLink(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement markAllRead = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[@class='ui menu link transition visible']//span//div//div[@class='ui link item']//div//a")));
            markAllRead.Click();
            Thread.Sleep(1000);

        }



        //SelectAllLink
        public void SelectAllLink(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement markAllRead = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//i[@class='mouse pointer icon']")));
            markAllRead.Click();
            Thread.Sleep(1000);

        }

        //ClickUnselectAllLink
        public void ClickUnselectAllLink(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement markAllRead = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[@class='ui icon basic button button-icon-style']")));
            markAllRead.Click();
            Thread.Sleep(1000);

        }

        //AllMessageShouldBeChecked
        public void AllMessageShouldBeChecked(IWebDriver driver1)
        {
            List<IWebElement> checkboxes = new List<IWebElement>(driver1.FindElements(By.XPath("//input[@type='checkbox']")));

            //foreach (IWebElement checkbox in checkboxes)
            //{
            //    bool isChecked = checkbox.Selected;
            //    // isChecked will be true if the checkbox is checked, false if not
            //}
            bool allChecked = true;

            foreach (IWebElement checkbox in checkboxes)
            {
                if (!checkbox.Selected)
                {
                    allChecked = false;
                    break; // Break out of the loop if any unchecked box is found
                }
            }

            if (allChecked)
            {
                Console.WriteLine("All checked");
            }
            else
            {
                Console.WriteLine("At least one checkbox is unchecked");
            }



        }


        //AllMessagesShouldBeUnchecked
        public void AllMessagesShouldBeUnchecked(IWebDriver driver1)
        {

            List<IWebElement> checkboxes = new List<IWebElement>(driver1.FindElements(By.XPath("//input[@type='checkbox']")));

            //foreach (IWebElement checkbox in checkboxes)
            //{
            //    bool isChecked = checkbox.Selected;
            //    // isChecked will be true if the checkbox is checked, false if not
            //}
            bool allChecked = false;

            foreach (IWebElement checkbox in checkboxes)
            {
                if (!checkbox.Selected)
                {
                    allChecked = true;
                    break; // Break out of the loop if any unchecked box is found
                }
            }

            if (allChecked)
            {
                Console.WriteLine("All checked");
            }
            else
            {
                Console.WriteLine("At least one checkbox is unchecked");
            }
        }


        //UserClickDeleteAMessage
        public void UserClickDeleteAMessage(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement checkBox1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input")));
            checkBox1.Click();
            Thread.Sleep(1000);
            IWebElement deleteButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[@data-tooltip='Delete selection']")));
            deleteButton.Click();

        }



        //DeleteOneNotificationFromTheNotificationPage

        public void DeleteOneNotification(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            IWebElement MessageDelete = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            string actualMessage = MessageDelete.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Notification updated";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }
        //WhenUserSelectAMessage
        public void UserSelectAMessage(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement notification1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/div[2]/a")));
            notification1.Click();
            Thread.Sleep(1000);
            
        }


        //ShowReceivedRequestsPage
        public void ShowReceivedRequestsPage(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            IWebElement MessageDelete = driver1.FindElement(By.XPath("//div[@class='ui container']//h2"));
            string actualMessage = MessageDelete.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Received Requests";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }



    }
}
