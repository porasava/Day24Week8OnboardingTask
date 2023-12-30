using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24Week8OnboardingTask.Pages
{
    public class Notification
    {
        // ClickOnNotification
        public void ClickOnNotification(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement Notification = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[@class='ui top left pointing dropdown item active visible']")));
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




        //DeleteOneNotificationFromTheNotificationPage



        //ShowReceivedRequestsPage




    }
}
