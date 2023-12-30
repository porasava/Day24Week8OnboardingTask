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
    [NUnit.Framework.DescriptionAttribute("AccountPassword")]
    public partial class AccountPasswordFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "008AccountPassword.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "AccountPassword", "Validate that the user able to change password", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("TS_107_TC_020 Verify that user change password with correct password")]
        [NUnit.Framework.TestCaseAttribute("Tananya1@hotmail.com", "TananyaHappy", "TananyaHappy", "TananyaHappy1", "TananyaHappy1", "TananyaHappy1", "TananyaHappy", "TananyaHappy", null)]
        public void TS_107_TC_020VerifyThatUserChangePasswordWithCorrectPassword(string userName, string password, string currentPassword, string newPassword, string confirmPassword, string currentPassword2, string newPassword2, string confirmPassword2, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("CurrentPassword", currentPassword);
            argumentsOfScenario.Add("NewPassword", newPassword);
            argumentsOfScenario.Add("ConfirmPassword", confirmPassword);
            argumentsOfScenario.Add("CurrentPassword2", currentPassword2);
            argumentsOfScenario.Add("NewPassword2", newPassword2);
            argumentsOfScenario.Add("ConfirmPassword2", confirmPassword2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_107_TC_020 Verify that user change password with correct password", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.When("I navigate to password pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.When(string.Format("I change password with \'{0}\', \'{1}\', \'{2}\'", currentPassword, newPassword, confirmPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("It should show pop up Password Changed Successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.Then(string.Format("I change password back with \'{0}\', \'{1}\', \'{2}\'", currentPassword2, newPassword2, confirmPassword2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS_107_TC_021 Verify that user change password with invalid current password")]
        [NUnit.Framework.TestCaseAttribute("Tananya1@hotmail.com", "TananyaHappy", "TananyaHappy4", "TananyaHappy1", "TananyaHappy1", null)]
        public void TS_107_TC_021VerifyThatUserChangePasswordWithInvalidCurrentPassword(string userName, string password, string currentPassword, string newPassword, string confirmPassword, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("CurrentPassword", currentPassword);
            argumentsOfScenario.Add("NewPassword", newPassword);
            argumentsOfScenario.Add("ConfirmPassword", confirmPassword);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_107_TC_021 Verify that user change password with invalid current password", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 21
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.When("I navigate to password pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.When(string.Format("I change password with \'{0}\', \'{1}\', \'{2}\'", currentPassword, newPassword, confirmPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("It should show pop up Password Verification Failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS_107_TC_022 Verify that user change password with blank current password")]
        [NUnit.Framework.TestCaseAttribute("Tananya1@hotmail.com", "TananyaHappy", "", "TananyaHappy1", "TananyaHappy1", null)]
        public void TS_107_TC_022VerifyThatUserChangePasswordWithBlankCurrentPassword(string userName, string password, string currentPassword, string newPassword, string confirmPassword, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("CurrentPassword", currentPassword);
            argumentsOfScenario.Add("NewPassword", newPassword);
            argumentsOfScenario.Add("ConfirmPassword", confirmPassword);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_107_TC_022 Verify that user change password with blank current password", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
 testRunner.When("I navigate to password pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.When(string.Format("I change password with \'{0}\', \'{1}\', \'{2}\'", currentPassword, newPassword, confirmPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.Then("It should show pop up Error while Updating Password details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS_107_TC_023 Verify that user change password with all blank")]
        [NUnit.Framework.TestCaseAttribute("Tananya1@hotmail.com", "TananyaHappy", "", "", "", null)]
        public void TS_107_TC_023VerifyThatUserChangePasswordWithAllBlank(string userName, string password, string currentPassword, string newPassword, string confirmPassword, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("CurrentPassword", currentPassword);
            argumentsOfScenario.Add("NewPassword", newPassword);
            argumentsOfScenario.Add("ConfirmPassword", confirmPassword);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_107_TC_023 Verify that user change password with all blank", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 44
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 45
 testRunner.When("I navigate to password pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.When(string.Format("I change password with \'{0}\', \'{1}\', \'{2}\'", currentPassword, newPassword, confirmPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("It should show pop up Error Please fill all the details before Submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS_107_TC_024 Verify that user change password with invalid new password format")]
        [NUnit.Framework.TestCaseAttribute("Tananya1@hotmail.com", "TananyaHappy", "TananyaHappy", "8888", "8888", null)]
        public void TS_107_TC_024VerifyThatUserChangePasswordWithInvalidNewPasswordFormat(string userName, string password, string currentPassword, string newPassword, string confirmPassword, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("CurrentPassword", currentPassword);
            argumentsOfScenario.Add("NewPassword", newPassword);
            argumentsOfScenario.Add("ConfirmPassword", confirmPassword);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_107_TC_024 Verify that user change password with invalid new password format", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 54
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 55
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 56
 testRunner.When("I navigate to password pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.When(string.Format("I change password with \'{0}\', \'{1}\', \'{2}\'", currentPassword, newPassword, confirmPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
 testRunner.Then("It should show pop up Error Passwords required at least 6 characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS_107_TC_025 Verify that the user changes the password without matching the conf" +
            "irm password")]
        [NUnit.Framework.TestCaseAttribute("Tananya1@hotmail.com", "TananyaHappy", "TananyaHappy", "TananyaHappy1", "TananyaHappy2", null)]
        public void TS_107_TC_025VerifyThatTheUserChangesThePasswordWithoutMatchingTheConfirmPassword(string userName, string password, string currentPassword, string newPassword, string confirmPassword, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("CurrentPassword", currentPassword);
            argumentsOfScenario.Add("NewPassword", newPassword);
            argumentsOfScenario.Add("ConfirmPassword", confirmPassword);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS_107_TC_025 Verify that the user changes the password without matching the conf" +
                    "irm password", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 65
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 66
 testRunner.Given(string.Format("I loged into Skill website successfully with \'{0}\' and \'{1}\'", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 67
 testRunner.When("I navigate to password pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When(string.Format("I change password with \'{0}\', \'{1}\', \'{2}\'", currentPassword, newPassword, confirmPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("It should show pop up Error Passwords does not match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
