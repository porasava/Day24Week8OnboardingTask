using Day24Week8OnboardingTask.Utilities;
using System;
using TechTalk.SpecFlow;
using Day24Week8OnboardingTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Security.Policy;
using System.Diagnostics.Metrics;

namespace Day24Week8OnboardingTask.StepDefinitions
{
    [Binding]
    public class AccountProfileStepDefinitions : CommonDriver
    {
        [Given(@"I loged into Skill website successfully with '([^']*)' and '([^']*)'")]
        public void GivenILogedIntoSkillWebsiteSuccessfullyWithAnd(string username, string password)
        {
            driver1 = new ChromeDriver();
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.LogedIntoSkillWebsite(driver1, username,password);

            
        }

        [When(@"I navigate to account profile")]
        public void WhenINavigateToAccountProfile()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.NavigateToAccountProfile(driver1);
        }

        [When(@"I edit firstname with '([^']*)'")]
        public void WhenIEditFirstnameWith(string firstname)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditFirstname(driver1,firstname);
        }


        [Then(@"It should show new Firstname")]
        public void ThenItShouldShowNewFirstname()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.NewFirstname(driver1);
        }


        [Then(@"I Edit back to the original firstname '([^']*)'")]
        public void ThenIEditBackToTheOriginalFirstname(string originalFirstName)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditBackToTheOriginalFirstname(driver1, originalFirstName);
            
        }

        [When(@"I edit Lastname with '([^']*)'")]
        public void WhenIEditLastnameWith(string lastNameEdit)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditLastname(driver1, lastNameEdit);
            
        }

        [Then(@"It shoulsd show new Lastname")]
        public void ThenItShoulsdShowNewLastname()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.ShowNewLastname(driver1);
           
        }

        [Then(@"I Edit back to the original Lastname '([^']*)'")]
        public void ThenIEditBackToTheOriginalLastname(string originalLastName)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditBackToTheOriginalLastname(driver1, originalLastName);
          
        }

        [When(@"I edit Description with '([^']*)'")]
        public void WhenIEditDescriptionWith(string description)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.editDescription(driver1, description);

        }

        [Then(@"Description should be edit successfully")]
        public void ThenDescriptionShouldBeEditSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.descriptionShouldBeEditSuccessfully(driver1);
            
        }

        [Then(@"I Edit back to the original Description '([^']*)'")]
        public void ThenIEditBackToTheOriginalDescription(string originalDescription)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditBackToTheOriginalDescription(driver1, originalDescription);
        }

        [When(@"I add new Language with '([^']*)', and '([^']*)'")]
        public void WhenIAddNewLanguageWithAnd(string language, string languageLevel)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.addNewLanguage(driver1, language, languageLevel);
           
        }

        [Then(@"Language should be add successfully")]
        public void ThenLanguageShouldBeAddSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.languageShouldBeAddSuccessfully(driver1);
           
        }

        [Then(@"Remove Language")]
        public void ThenRemoveLanguage()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.RemoveLanguage(driver1);
            
        }

        [Then(@"Language should be remove successfully")]
        public void ThenLanguageShouldBeRemoveSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.LanguageShouldBeRemoveSuccessful(driver1);
        }


        [Then(@"It should show error Please enter language and level")]
        public void ThenItShouldShowErrorPleaseEnterLanguageAndLevel()
        {
            
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.ErrorPleaseenterlanguageandlevel(driver1);
        }


        [When(@"I edit a Language with '([^']*)'")]
        public void WhenIEditALanguageWith(string language)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditALanguage(driver1, language);
           
        }

        [Then(@"Language should be Edited successfully , '([^']*)'")]
        public void ThenLanguageShouldBeEditedSuccessfully(string languageEdit)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.LanguageShouldBeEdited(driver1,languageEdit);
            
        }

   
        [When(@"I delete a Language '([^']*)'")]
        public void WhenIDeleteALanguage(string languageDelete)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.DeleteALanguage(driver1, languageDelete);
            
        }
        [Then(@"Language should be remove successful")]
        public void ThenLanguageShouldBeRemoveSuccessful()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.LanguageShouldBeRemoveSuccessful(driver1);
           
        }


        [When(@"I add a new Skill with '([^']*)', and '([^']*)'")]
        public void WhenIAddANewSkillWithAnd(string skill, string skillLevel)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.AddANewSkill(driver1, skill, skillLevel);

        }

        [Then(@"It shoulsd show new Skill")]
        public void ThenItShoulsdShowNewSkill()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.ShowNewSkill(driver1);
        }

        [Then(@"I delete a Skill '([^']*)'")]
        public void ThenIDeleteASkill(string skillDelete)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.DeleteASkill(driver1, skillDelete);
        }

        [Then(@"Skill should be remove successfully")]
        public void ThenSkillShouldBeRemoveSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.SkillShouldBeRemoveSuccessfully(driver1);
        }


        [Then(@"It shoulsd show error Please enter skill and experience level")]
        public void ThenItShoulsdShowErrorPleaseEnterSkillAndExperienceLevel()
        {
 
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.ErrorPleaseEnterSkillAndExperienceLevel(driver1);
        }

 

        [When(@"I edit a skill with '([^']*)'")]
        public void WhenIEditASkillWith(string skill)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditASkill(driver1, skill);
        }

        [Then(@"The skill should edit successfully")]
        public void ThenTheSkillShouldEditSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.SkillShouldEditSuccessfully(driver1);
        }





        [When(@"I delete a skill with '([^']*)'")]
        public void WhenIDeleteASkillWith(string skillDelete)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.DeleteASkill(driver1, skillDelete);
        }

        [Then(@"The skill should delete successfully")]
        public void ThenTheSkillShouldDeleteSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.SkillShouldBeRemoveSuccessfully(driver1);
        }

        [When(@"I add a new Education with '([^']*)', '([^']*)', '([^']*)', '([^']*)', and '([^']*)'")]
        public void WhenIAddANewEducationWithAnd(string universityName, string country, string title, string degree, string yearOfGraduate)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.AddANewEducation(driver1, universityName, country, title, degree, yearOfGraduate);
        }

        [Then(@"Education should be add successfully")]
        public void ThenEducationShouldBeAddSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EducationShouldBeAddSuccessfully(driver1);
        }

        [Then(@"I delete a Education with '([^']*)'")]
        public void ThenIDeleteAEducationWith(string educationDelete)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.DeleteAEducation(driver1, educationDelete);
        }

        [Then(@"The Education should delete successfully")]
        public void ThenTheEducationShouldDeleteSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EducationShouldDeleteSuccessfully(driver1);
        }

        [When(@"I edit Education with '([^']*)', '([^']*)', '([^']*)', '([^']*)', and '([^']*)'")]
        public void WhenIEditEducationWith(string universityNameEdit, string countryEdit, string titleEdit, string degreeEdit, string yearOfGraduateEdit)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditEducation(driver1, universityNameEdit, countryEdit, titleEdit, degreeEdit, yearOfGraduateEdit);

        }

        [Then(@"It should show error  Please enter all the fields")]
        public void ThenItShouldShowErrorPleaseEnterAllTheFields()
        {
            
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EducationErrorPleaseEnterAllTheFields(driver1);
        }

        [When(@"I delete Education with '([^']*)'")]
        public void WhenIDeleteEducationWith(string educationDelete)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.DeleteAEducation(driver1, educationDelete);
        }


        [When(@"I add a new Certification with '([^']*)', '([^']*)', and '([^']*)'")]
        public void WhenIAddANewCertificationWithAnd(string certificateOrAward, string from, string year)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.AddANewCertification(driver1,certificateOrAward, from, year);
        }

        [Then(@"Certification should be add successfully")]
        public void ThenCertificationShouldBeAddSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.CertificationShouldBeAddSuccessfully(driver1);
        }

        [Then(@"I delete Certification with '([^']*)'")]
        public void ThenIDeleteCertificationWith(string certificateDelete)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.DeleteCertification(driver1, certificateDelete);
        }

        [Then(@"The Certification should delete successfully")]
        public void ThenTheCertificationShouldDeleteSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.CertificationShouldDeleteSuccessfully(driver1);
        }



        [Then(@"Certification should be delete successfully")]
        public void ThenCertificationShouldBeDeleteSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then(@"It should show error Please enter Certification Name, Certification From and Certification Year")]
        public void ThenItShouldShowErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear(driver1);
        }


        [When(@"I edit a Certification with '([^']*)', '([^']*)', and '([^']*)'")]
        public void WhenIEditACertificationWithAnd(string certificateOrAwardEdit, string fromEdit, string yearEdit)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.EditACertification(driver1,certificateOrAwardEdit, fromEdit, yearEdit);
        }       
        
        
        [Then(@"Certification should be edit successfully")]
        public void ThenCertificationShouldBeEditSuccessfully()
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.CertificationShouldBeEdit(driver1);
        }

        [When(@"I delete Certification with '([^']*)'")]
        public void WhenIDeleteCertificationWith(string certificateDelete)
        {
            AccountProfile AccountPageObj = new AccountProfile();
            AccountPageObj.DeleteCertification(driver1, certificateDelete);
        }
    }
}
