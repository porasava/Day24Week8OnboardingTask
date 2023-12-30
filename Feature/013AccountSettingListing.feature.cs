﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Day24Week8OnboardingTask.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("013AccountSettingListing")]
    public partial class _013AccountSettingListingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "013AccountSettingListing.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "013AccountSettingListing", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1TS_113_TC_031 Verify the user click edit listing link on manage listings page")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Graphics Design Tananya", "Graphics Design Tananya", "Graphics & Design", "Logo Design", "Tananya", "Graphics & Design", "Graphics Design Tananya1", "Graphics Design Tananya1", "Graphics & Design", "Logo Design", "Tananya", "Graphics & Design", null)]
        public void _1TS_113_TC_031VerifyTheUserClickEditListingLinkOnManageListingsPage(string userName, string password, string title, string description, string category, string subCategory, string tags, string skillExchange, string titleEdit, string descriptionEdit, string categoryEdit, string subCategoryEdit, string tagsEdit, string skillExchangeEdit, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Title", title);
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("Category", category);
            argumentsOfScenario.Add("SubCategory", subCategory);
            argumentsOfScenario.Add("Tags", tags);
            argumentsOfScenario.Add("SkillExchange", skillExchange);
            argumentsOfScenario.Add("TitleEdit", titleEdit);
            argumentsOfScenario.Add("DescriptionEdit", descriptionEdit);
            argumentsOfScenario.Add("CategoryEdit", categoryEdit);
            argumentsOfScenario.Add("SubCategoryEdit", subCategoryEdit);
            argumentsOfScenario.Add("TagsEdit", tagsEdit);
            argumentsOfScenario.Add("SkillExchangeEdit", skillExchangeEdit);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1TS_113_TC_031 Verify the user click edit listing link on manage listings page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.Given(string.Format("I create a listing \'{0}\', \'{1}\', \'{2}\',\'{3}\',\'{4}\',\'{5}\'", title, description, category, subCategory, tags, skillExchange), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.When("I navigate to Manage listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.When(string.Format("I edit listing \'{0}\', \'{1}\', \'{2}\',\'{3}\',\'{4}\',\'{5}\'", titleEdit, descriptionEdit, categoryEdit, subCategoryEdit, tagsEdit, skillExchangeEdit), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("It should show the listing update on the listing detail page \'{0}\', \'{1}\'", title, description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2TS_113_TC_032 Verify the user click on see listing link on manage listings page")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Graphics Design Tananya1", "Graphics Design Tananya1", "Graphics & Design", "Logo Design", "Graphics & Design", "Online", null)]
        public void _2TS_113_TC_032VerifyTheUserClickOnSeeListingLinkOnManageListingsPage(string userName, string password, string title, string description, string category, string subCategory, string skillExchange, string locationType, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Title", title);
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("Category", category);
            argumentsOfScenario.Add("SubCategory", subCategory);
            argumentsOfScenario.Add("SkillExchange", skillExchange);
            argumentsOfScenario.Add("LocationType", locationType);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2TS_113_TC_032 Verify the user click on see listing link on manage listings page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
 testRunner.When("I navigate to Manage listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.When("I click on see listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then(string.Format("It should show the listing on the listing detail page \'{0}\', \'{1}\', \'{2}\',\'{3}\',\'" +
                            "{4}\',\'{5}\'", title, description, category, subCategory, skillExchange, locationType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3TS_113_TC_035 Verify the user click on Deactivate listing link on manage listing" +
            "s page")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Graphics Design Tananya1", null)]
        public void _3TS_113_TC_035VerifyTheUserClickOnDeactivateListingLinkOnManageListingsPage(string userName, string password, string title, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Title", title);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3TS_113_TC_035 Verify the user click on Deactivate listing link on manage listing" +
                    "s page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 31
 testRunner.When("I navigate to Manage listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.When("I click on Deactivate listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("It should show Service has been deactivated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4TS_113_TC_034 Verify the user click on activate listing link on manage listings " +
            "page")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Graphics Design Tananya1", null)]
        public void _4TS_113_TC_034VerifyTheUserClickOnActivateListingLinkOnManageListingsPage(string userName, string password, string title, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Title", title);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4TS_113_TC_034 Verify the user click on activate listing link on manage listings " +
                    "page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 41
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 42
 testRunner.When("I navigate to Manage listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.When("I click on activate listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("It should show Service has been activated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("5TS_113_TC_033 Verify the user click on delete listing link on manage listings pa" +
            "ge")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Graphics Design Tananya1", null)]
        public void _5TS_113_TC_033VerifyTheUserClickOnDeleteListingLinkOnManageListingsPage(string userName, string password, string title, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Title", title);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5TS_113_TC_033 Verify the user click on delete listing link on manage listings pa" +
                    "ge", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 52
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 53
 testRunner.When("I navigate to Manage listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.When(string.Format("I click on delete listing \'{0}\'", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("The listing should be delete successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
