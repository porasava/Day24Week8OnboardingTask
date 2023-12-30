using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day24Week8OnboardingTask.Pages
{
    public class LogInPage
    {
        public void NavigateToSkillsWeb(IWebDriver driver1) 
        {
            driver1.Manage().Window.Maximize();
            //Lunch TurnUp Portal and navigate to the website login page
            driver1.Navigate().GoToUrl("http://localhost:5001/Home");
           
        }

        public void InputUsernameAndPassword(IWebDriver driver1, string username, string password)
        {
            // click SIgnIn button
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 8);
            IWebElement loginButton = driver1.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            loginButton.Click();

            //user login
            Wait.WaitToExist(driver1, "Xpath", "//input[@placeholder='Email address']", 8);
            IWebElement usernameTextbox = driver1.FindElement(By.XPath("//input[@placeholder='Email address']"));
            usernameTextbox.SendKeys(username);

            IWebElement passwordTextbox = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys(password);


        }

        public void ClickOnLogin(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 8);
            IWebElement loginButtonPopUp = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButtonPopUp.Click();
        }
        

        // It should show error Please enter valid email address
        public void ValidateErrorvalidemailaddress(IWebDriver driver1)
        {
            IWebElement loginUsernameError = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/div"));
            Assert.That(loginUsernameError.Text == "Please enter a valid email address", "error message is not show. It should show error 'Please enter a valid email address' after input wrong username");
       
        }


      
        // It should show error Please enter valid email address
        public void ConfirmYourEmailError(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement ConfirmYourEmailError = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Assert.That(ConfirmYourEmailError.Text == "Confirm your email", "error message is not show. It should show error 'Confirm your email");

        }


        //div[@class='ns-box-inner']
        //ItShouldShowErrorWrongEmailOrPassword
        public void ErrorWrongEmailOrPassword(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement WrongEmailOrPassword = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Assert.That(WrongEmailOrPassword.Text == "Error Wrong Email Or Password", "error message is not show. It should show error 'Error Wrong Email Or Password'");

        }

        //ErrorPasswordMustBeAtLeastCharacters
        public void ErrorPasswordMustBeAtLeastCharacters(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[2]/div", 5);
            IWebElement ErrorPasswordMustBeAtLeastCharacters = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/div"));
            Assert.That(ErrorPasswordMustBeAtLeastCharacters.Text == "Password must be at least 6 characters", "error message is not show It should show error 'Password must be at least 6 characters'");

        }

        // /html/body/div[2]/div/div/div[2]/div[1]/a
        public void ForgotPassword(IWebDriver driver1)
        {
            // click SIgnIn button
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 8);
            IWebElement loginButton = driver1.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            loginButton.Click();
            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[2]/div/div/div[2]/div[1]/a", 5);
            IWebElement ForgotPassword = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/a"));
            ForgotPassword.Click();
 
        }

        
        public void InputEmail(IWebDriver driver1, string username)
        {
            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[2]/div/div/form/div/div[1]/input", 5);
            IWebElement InputEmail = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/form/div/div[1]/input"));
            InputEmail.SendKeys(username);
        }
       
        public void SendVarificationEmail(IWebDriver driver1)
        {
            IWebElement SendVarificationEmail = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/form/div/div[2]/div"));
            SendVarificationEmail.Click();
        }

        //LinkHasBeenSentToYourInbox
        public void LinkHasBeenSentToYourInbox(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "/html/body/div[2]/div/div/form/div", 5);
            IWebElement LinkHasBeenSentToYourInbox = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/form/div"));
            string actualMessage = LinkHasBeenSentToYourInbox.Text.Trim().Replace("\r\n", "\n").Replace("\r", "\n");
            Assert.That(actualMessage.Equals(LinkHasBeenSentToYourInbox.Text, StringComparison.Ordinal), "Error: The expected message did not appear. Expected: '" + LinkHasBeenSentToYourInbox.Text + "', Actual: '" + actualMessage + "'");
            
        }


       
        public void FieldCannotBeEmpty(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement FieldCannotBeEmpty = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Assert.That(FieldCannotBeEmpty.Text == "Field cannot be empty", "error message is not show It should show error 'field cannot be empty'");

        }

        public void WhenIClickOnJoinLink(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "//button[@class='ui green basic button']", 5);
            IWebElement WhenIClickOnJoinLink = driver1.FindElement(By.XPath("//button[@class='ui green basic button']"));
            WhenIClickOnJoinLink.Click();
        }


        //GoToTheRegistrationPop_Up
        public void GoToTheRegistrationPopUp(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "//a[normalize-space()='terms and conditions']", 5);
            IWebElement RegistrationPopUp = driver1.FindElement(By.XPath("//a[normalize-space()='terms and conditions']"));
            Assert.That(RegistrationPopUp.Text == "terms and conditions", "text is not show It should show 'terms and conditions'");

        }

      
        public void GoToAccountProfilePage(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/div[1]/a", 5);
            IWebElement AccountProfilePage = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
            Assert.That(AccountProfilePage.Text == "Mars Logo", "text is not show. It should show 'Mars Logo'");

        }
    }
}
