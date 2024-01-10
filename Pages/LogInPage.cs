using Day24Week8OnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;



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
        
              
      
        public void GoToAccountProfilePage(IWebDriver driver1)
        {
            Wait.WaitToExist(driver1, "Xpath", "//*[@id=\"account-profile-section\"]/div/div[1]/a", 5);
            IWebElement AccountProfilePage = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
            Assert.That(AccountProfilePage.Text == "Mars Logo", "text is not show. It should show 'Mars Logo'");

        }
    }
}
