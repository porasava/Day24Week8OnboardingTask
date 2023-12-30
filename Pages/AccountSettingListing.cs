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
using System.Xml.Linq;

namespace Day24Week8OnboardingTask.Pages
{
    public class AccountSettingListing
    {
        //CreateAListing
        public void CreateAListing(IWebDriver driver1, string title, string description, string category, string subCategory, string tags,string skillExchange)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement shareSkillButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Share Skill']")));
            shareSkillButton.Click();
            Thread.Sleep(1000);
            IWebElement shareSkillTitle = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']")));
            shareSkillTitle.SendKeys(title);
            IWebElement descriptionText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")));
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            IWebElement categoryDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name='categoryId']")));
            categoryDropdown.SendKeys(category);
            if (string.IsNullOrEmpty(subCategory))
            {
                IWebElement tagsText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")));
                tagsText.SendKeys(tags);
                tagsText.SendKeys(Keys.Enter);
            }
            IWebElement skillExchangeText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]")));
            skillExchangeText.Click();
            skillExchangeText.SendKeys(skillExchange);
            skillExchangeText.SendKeys(Keys.Enter);
            IWebElement shareSkillSave = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@value='Save']")));
            shareSkillSave.Click();
        }

        public void EditAListing(IWebDriver driver1, string title, string description, string category, string subCategory, string tags, string skillExchange)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement EditSkillButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[2]/i[1]")));
            EditSkillButton.Click();
            Thread.Sleep(1000);
            IWebElement shareSkillTitle = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']")));
            shareSkillTitle.Clear();
            shareSkillTitle.SendKeys(title);
            IWebElement descriptionText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")));
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            IWebElement categoryDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name='categoryId']")));
            categoryDropdown.SendKeys(category);
            IWebElement subCategoryDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name='subcategoryId']")));
            subCategoryDropdown.Click();
            subCategoryDropdown.SendKeys(subCategory);
            IWebElement tagsText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")));
            tagsText.SendKeys(tags);
            tagsText.SendKeys(Keys.Enter);
            IWebElement skillExchangeText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]")));
            skillExchangeText.Click();
            skillExchangeText.SendKeys(skillExchange);
            skillExchangeText.SendKeys(Keys.Enter);
            IWebElement shareSkillSave = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@value='Save']")));
            shareSkillSave.Click();
        }

        //NavigateToManageListingPage
        public void NavigateToManageListingPage(IWebDriver driver1)
        {
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement manageListingButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[normalize-space()='Manage Listings']")));
            manageListingButton.Click();
            Thread.Sleep(1000);
        }

        //ListingUpdateOnTheListingDetailPage
        public void ListingUpdateOnTheListingDetailPage(IWebDriver driver1, string title, string description)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement seeButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//i[@class='eye icon']")));
            seeButton.Click();
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, "Xpath", "//span[@class='skill-title']", 5);
            IWebElement skillTitle = driver1.FindElement(By.XPath("//span[@class='skill-title']"));
            string actualText = skillTitle.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = title;

            // Assert that the actual message contains the expected static part
            Assert.That(actualText.Contains(expectedStaticPart),
                $"The actual text '{actualText}' does not contain the expected text '{expectedStaticPart}'.");

            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='sixteen wide column']//div[@class='description'][contains(text(),'Graphics')]", 5);
            IWebElement descriptionText = driver1.FindElement(By.XPath("//div[@class='sixteen wide column']//div[@class='description'][contains(text(),'Graphics')]"));
            string actualdescriptionText = descriptionText.Text.Trim();

            // The static part of the message you expect
            string expectedDescriptionTextStaticPart = description;

            // Assert that the actual message contains the expected static part
            Assert.That(actualText.Contains(expectedDescriptionTextStaticPart),
                $"The actual text '{actualdescriptionText}' does not contain the expected text '{expectedDescriptionTextStaticPart}'.");

        }

        //ClickOnSeeListing
        public void ClickOnSeeListing(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            IWebElement seeButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//i[@class='eye icon']")));
            seeButton.Click();
            Thread.Sleep(1000);
        }

        //ShowTheListingOnTheListingDetailPage
        public void ShowTheListingOnTheListingDetailPage(IWebDriver driver1, string title, string description,string Category,string SubCategory,string SkillExchange,string LocationType)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Thread.Sleep(1000);
            IWebElement skillTitle = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class='skill-title']")));
            string skillTitleactualText = skillTitle.Text.Trim();
            // The static part of the message you expect
            Assert.That(skillTitleactualText.Contains(title), $"Title of element does not match expected.");
            
            IWebElement descriptionText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]")));
            string descriptionactualText = descriptionText.Text.Trim();
            // The static part of the message you expect
            Assert.That(descriptionactualText.Contains(description), $"Description of element does not match expected.");
            
            IWebElement categoryText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]")));
            string categoryactualText = categoryText.Text.Trim();
            // The static part of the message you expect
            Assert.That(categoryactualText.Contains(Category), $"category of element does not match expected.");
            
            IWebElement subCategoryText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]")));
            string subCategoryactualText = subCategoryText.Text.Trim();
            // The static part of the message you expect
            Assert.That(subCategoryactualText.Contains(SubCategory), $"subCategory of element does not match expected.");
                               
            IWebElement skillExchangeText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class='ui tag label']")));
            string skillExchangeactualText = skillExchangeText.Text.Trim();
            // The static part of the message you expect
            Assert.That(skillExchangeactualText.Contains(SkillExchange), $"skillExchange of element does not match expected.");
            
            IWebElement locationText = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ui container']//div[3]//div[1]//div[3]//div[1]//div[2]")));
            string locationactualText = locationText.Text.Trim();
            // The static part of the message you expect
            Assert.That(locationactualText.Contains(LocationType), $"location of element does not match expected.");


             
        }

        //ClickOnDeactivateListing
        public void ClickOnDeactivateListing(IWebDriver driver1)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
           // IWebElement DeactivateButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div/input")));
            IWebElement DeactivateButton = driver1.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div/input"));
            DeactivateButton.Click();
            Thread.Sleep(1000);
        }

        //ShowServiceHasBeenDeactivated
        public void ShowServiceHasBeenDeactivated(IWebDriver driver1)
        {

            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Service has been deactivated";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");

        }


        //ServiceHasBeenActivated
        public void ServiceHasBeenActivated(IWebDriver driver1)
        {
            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement activateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string actualactivateCheck = activateCheck.Text.Trim();

            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Service has been activated";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");

        }


        //DeleteListing
        public void DeleteListing(IWebDriver driver1,string title)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.ElementIsVisible(driver1, "Xpath", "//tbody/tr[1]/td[3]", 5);
            IWebElement deleteCheck = driver1.FindElement(By.XPath("//tbody/tr[1]/td[3]"));
            string actualdeleteCheck = deleteCheck.Text.Trim();

            // The static part of the message you expect
            string expecteddeleteCheckStaticPart = title;

            // Assert that the actual message contains the expected static part
            Assert.That(actualdeleteCheck.Contains(expecteddeleteCheckStaticPart),
                $"The actual text '{actualdeleteCheck}' does not contain the expected text '{expecteddeleteCheckStaticPart}'.");
            IWebElement deleteButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]")));
            deleteButton.Click();
            Thread.Sleep(1000);
            IWebElement yesButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='ui icon positive right labeled button']")));
            yesButton.Click();
        }




        //ListingShouldBeDeleteSuccessfully
        public void ListingShouldBeDeleteSuccessfully(IWebDriver driver1)
        {

            Wait.ElementIsVisible(driver1, "Xpath", "//div[@class='ns-box-inner']", 5);
            IWebElement deleteCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string actualdeleteCheck = deleteCheck.Text.Trim();

            // The static part of the message you expect
            string expecteddeleteCheckStaticPart = "has been deleted";

            // Assert that the actual message contains the expected static part
            Assert.That(actualdeleteCheck.Contains(expecteddeleteCheckStaticPart),
                $"The actual text '{actualdeleteCheck}' does not contain the expected text '{expecteddeleteCheckStaticPart}'.");

        }



    }
}
