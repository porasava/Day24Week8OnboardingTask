using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;



namespace Day24Week8OnboardingTask.Pages
{
    public class LogInPage

    {
        private readonly IWebDriver driver1;

        public LogInPage(IWebDriver _driver)
        {
            driver1 = _driver;
        }
      private IWebElement loginButton => driver1.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
      private  IWebElement usernameTextbox => driver1.FindElement(By.XPath("//input[@placeholder='Email address']"));
      private IWebElement passwordTextbox => driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
      private IWebElement loginButtonPopUp => driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
      private IWebElement AccountProfilePage => driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
        public void NavigateToSkillsWeb() 
        {
            driver1.Manage().Window.Maximize();
            //Lunch TurnUp Portal and navigate to the website login page
            driver1.Navigate().GoToUrl("http://localhost:5001/Home");
        }

        public void InputUsernameAndPassword(string username, string password)
        {
            // click SIgnIn button
       //     Wait.WaitToExist(driver1, loginButton, 8);
            loginButton.Click();

            //user login
         //   Wait.WaitToExist(driver1, usernameTextbox, 8);
            usernameTextbox.SendKeys(username);
            passwordTextbox.SendKeys(password);
        }

        public void ClickOnLogin()
        {
        //    Wait.WaitToExist(driver1, loginButtonPopUp, 8);
            loginButtonPopUp.Click();
        }
 
        public void GoToAccountProfilePage()
        {
       //     Wait.WaitToExist(driver1, AccountProfilePage, 5);
            Assert.That(AccountProfilePage.Text == "Mars Logo", "text is not show. It should show 'Mars Logo'");
        }
    }
}
