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
    [NUnit.Framework.DescriptionAttribute("005AccountProfileEditSkill")]
    public partial class _005AccountProfileEditSkillFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "005AccountProfileEditSkill.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "005AccountProfileEditSkill", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("TS_202_TC_001 Verify that the user edit a skill on the account profile page")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Communication", "Expert", "Teamwork", "Teamwork", null)]
        public void TS_202_TC_001VerifyThatTheUserEditASkillOnTheAccountProfilePage(string userName, string password, string skill, string skillLevel, string skillEdit, string skillDelete, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Skill", skill);
            argumentsOfScenario.Add("SkillLevel", skillLevel);
            argumentsOfScenario.Add("SkillEdit", skillEdit);
            argumentsOfScenario.Add("SkillDelete", skillDelete);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_202_TC_001 Verify that the user edit a skill on the account profile page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.When("I navigate to account profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.When(string.Format("I add a new Skill with \'{0}\', and \'{1}\'", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.When(string.Format("I edit a skill with \'{0}\'", skillEdit), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("The skill should edit successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.Then(string.Format("I delete a Skill \'{0}\'", skillDelete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.Then("Skill should be remove successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS_202_TC_002 Verify that the user edit a skill on the account profile page with " +
            "blank skill field")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Communication", "Expert", "Teamwork", "Teamwork", null)]
        public void TS_202_TC_002VerifyThatTheUserEditASkillOnTheAccountProfilePageWithBlankSkillField(string userName, string password, string skill, string skillLevel, string skillEdit, string skillDelete, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Skill", skill);
            argumentsOfScenario.Add("SkillLevel", skillLevel);
            argumentsOfScenario.Add("SkillEdit", skillEdit);
            argumentsOfScenario.Add("SkillDelete", skillDelete);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_202_TC_002 Verify that the user edit a skill on the account profile page with " +
                    "blank skill field", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.When("I navigate to account profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.When(string.Format("I add a new Skill with \'{0}\', and \'{1}\'", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.When(string.Format("I edit a skill with \'{0}\'", skillEdit), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("The skill should edit successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.Then(string.Format("I delete a Skill \'{0}\'", skillDelete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.Then("Skill should be remove successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS_202_TC_003 Verify that the user edit a skill on the account profile page with " +
            "same skill field")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Communication", "Expert", "Teamwork", "Teamwork", null)]
        public void TS_202_TC_003VerifyThatTheUserEditASkillOnTheAccountProfilePageWithSameSkillField(string userName, string password, string skill, string skillLevel, string skillEdit, string skillDelete, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Skill", skill);
            argumentsOfScenario.Add("SkillLevel", skillLevel);
            argumentsOfScenario.Add("SkillEdit", skillEdit);
            argumentsOfScenario.Add("SkillDelete", skillDelete);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_202_TC_003 Verify that the user edit a skill on the account profile page with " +
                    "same skill field", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 34
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 35
 testRunner.When("I navigate to account profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.When(string.Format("I add a new Skill with \'{0}\', and \'{1}\'", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.When(string.Format("I edit a skill with \'{0}\'", skillEdit), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("The skill should edit successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.Then(string.Format("I delete a Skill \'{0}\'", skillDelete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.Then("Skill should be remove successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS_202_TC_004 Verify that the user edit a skill level on the account profile page" +
            " to be skill level")]
        [NUnit.Framework.TestCaseAttribute("Tananya@hotmail.com", "TananyaHappy", "Communication", "Expert", "Teamwork", "Teamwork", null)]
        public void TS_202_TC_004VerifyThatTheUserEditASkillLevelOnTheAccountProfilePageToBeSkillLevel(string userName, string password, string skill, string skillLevel, string skillEdit, string skillDelete, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Skill", skill);
            argumentsOfScenario.Add("SkillLevel", skillLevel);
            argumentsOfScenario.Add("SkillEdit", skillEdit);
            argumentsOfScenario.Add("SkillDelete", skillDelete);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_202_TC_004 Verify that the user edit a skill level on the account profile page" +
                    " to be skill level", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 48
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 49
 testRunner.When("I navigate to account profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.When(string.Format("I add a new Skill with \'{0}\', and \'{1}\'", skill, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.When(string.Format("I edit a skill with \'{0}\'", skillEdit), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("The skill should edit successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.Then(string.Format("I delete a Skill \'{0}\'", skillDelete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.Then("Skill should be remove successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
