using Day24Week8OnboardingTask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day24Week8OnboardingTask.Utilities;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;


namespace Day24Week8OnboardingTask.Pages
{
    public class registrationPage
    {

        //CreateANewAccount
        public void CreateANewAccount(IWebDriver driver1, string firstName, string lastName, string email, string password, string confirmPassword, string agree)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement skillTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Join']")));
            skillTab.Click();
            Thread.Sleep(1000);
            IWebElement firstnameText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='First name']")));
            firstnameText.SendKeys(firstName.ToString());
            IWebElement lastnameText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Last name']")));
            lastnameText.SendKeys(lastName);
            IWebElement emailText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Email address']")));
            emailText.SendKeys(email);
            IWebElement passwordText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Password']")));
            passwordText.SendKeys(password);
            IWebElement confirmPasswordText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Confirm Password']")));
            confirmPasswordText.SendKeys(confirmPassword);

            // Your existing code to locate the checkbox
            IWebElement agreeCheckbox = driver1.FindElement(By.XPath("//input[@type='checkbox' and @name='terms']"));

            // JavaScript Executor to forcefully click the checkbox
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver1;
            js.ExecuteScript("arguments[0].click();", agreeCheckbox);
            if (agree.ToLower() == "check") // If user input is "check"
            {
                if (!agreeCheckbox.Selected) // and checkbox isn't already checked
                {
                    agreeCheckbox.Click(); // then click to check it
                }
            }
            else if (agree.ToLower() == "uncheck") // If user input is "uncheck"
            {
                if (agreeCheckbox.Selected) // and checkbox is currently checked
                {
                    agreeCheckbox.Click(); // then click to uncheck it
                }
            }

            IWebElement joinButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='submit-btn']")));
            joinButton.Click();            
        }

        //ErrorMessageNamesMustContainAtLeastOneLetter
        public void ErrorMessageNamesMustContainAtLeastOneLetter(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ui basic red pointing prompt label transition visible']", 5);
            IWebElement Firstname = driver1.FindElement(By.XPath("//div[@class='ui basic red pointing prompt label transition visible']"));
            string actualMessage = Firstname.Text.Trim();
            string expectedMessage = "Names must contain at least one letter"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //ErrorMessageLastnamesMustContainAtLeastOneLetter
        public void ErrorMessageLastnamesMustContainAtLeastOneLetter(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ui page modals dimmer transition visible active']//div[2]//div[1]", 5);
            IWebElement lastName = driver1.FindElement(By.XPath("//div[@class='ui page modals dimmer transition visible active']//div[2]//div[1]"));
            string actualMessage = lastName.Text.Trim();
            string expectedMessage = "Names must contain at least one letter"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //ErrorMessagePleaseEnterAValidEmailAddress
        public void ErrorMessagePleaseEnterAValidEmailAddress(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//div[contains(text(),'Please enter a valid email address.')]", 5);
            IWebElement email = driver1.FindElement(By.XPath("//div[contains(text(),'Please enter a valid email address.')]"));
            string actualMessage = email.Text.Trim();
            string expectedMessage = "Please enter a valid email address."; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //ErrorMessagePasswordMustBeAtLeastCharacters
        public void ErrorMessagePasswordMustBeAtLeastCharacters(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//div[contains(text(),'Password must be at least 6 characters.')]", 5);
            IWebElement Password = driver1.FindElement(By.XPath("//div[contains(text(),'Password must be at least 6 characters.')]"));
            string actualMessage = Password.Text.Trim();
            string expectedMessage = "Password must be at least 6 characters."; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //ErrorMessageDoesNotMatchPassword
        public void ErrorMessageDoesNotMatchPassword(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//div[contains(text(),'Does not match password.')]", 5);
            IWebElement Password = driver1.FindElement(By.XPath("//div[contains(text(),'Does not match password.')]"));
            string actualMessage = Password.Text.Trim();
            string expectedMessage = "Does not match password."; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //ErrorMessageYouMustAgreeToTheTermsAndConditions
        public void ErrorMessageYouMustAgreeToTheTermsAndConditions(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//p[normalize-space()='You must agree to the terms and conditions.']", 5);
            IWebElement TermsAndConditions = driver1.FindElement(By.XPath("//p[normalize-space()='You must agree to the terms and conditions.']"));
            string actualMessage = TermsAndConditions.Text.Trim();
            string expectedMessage = "You must agree to the terms and conditions."; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //signInSuccessfully
        public void signInSuccessfully(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            IWebElement greetingElement = driver1.FindElement(By.XPath("//a[normalize-space()='Mars Logo']"));
            string actualMessage = greetingElement.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Mars Logo";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }


    }
}
