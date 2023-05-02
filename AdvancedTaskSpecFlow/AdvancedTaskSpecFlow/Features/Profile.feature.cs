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
// Generation customised by SpecFlow.Contrib.Variants
namespace AdvancedTaskSpecFlow.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("This features captures all valid test cases for the below mentioned acceptance cr" +
        "iteria")]
    public partial class ThisFeaturesCapturesAllValidTestCasesForTheBelowMentionedAcceptanceCriteriaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Profile.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "This features captures all valid test cases for the below mentioned acceptance cr" +
                    "iteria", "\t* User is able to update the Description on the Profile page.\r\n\t* User is able t" +
                    "o change the password on the Profile page.\r\n\t* User is able to verify Received a" +
                    "nd Sent Requests on the Manage Requests page", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify user is able to update description details")]
        [NUnit.Framework.CategoryAttribute("Test")]
        public virtual void VerifyUserIsAbleToUpdateDescriptionDetails()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify user is able to update description details", null, new string[] {
                        "Test"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("user has signed in using valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user navigates to the profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user clicks on the pencil icon next to Description title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("user enters text in the Description text box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("user clicks on the Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Description details are saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify user is able to update password")]
        [NUnit.Framework.CategoryAttribute("Test")]
        public virtual void VerifyUserIsAbleToUpdatePassword()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify user is able to update password", null, new string[] {
                        "Test"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("user has signed in using valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user navigates to the profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user clicks on the Hi Firstname on the top right corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user clicks on the Change Password option from the dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("user enters Current Password, New Password, and Confirm Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.When("user clicks on the Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("New password details are saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify user is able to verify Received Requests")]
        [NUnit.Framework.CategoryAttribute("Test")]
        public virtual void VerifyUserIsAbleToVerifyReceivedRequests()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify user is able to verify Received Requests", null, new string[] {
                        "Test"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("user has signed in using valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user navigates to the profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user clicks on Manage Requests tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("user clicks on Received Requests menu option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("user navigates to Received Requests page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify user is able to verify Sent Requests")]
        [NUnit.Framework.CategoryAttribute("Test")]
        public virtual void VerifyUserIsAbleToVerifySentRequests()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify user is able to verify Sent Requests", null, new string[] {
                        "Test"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("user has signed in using valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user navigates to the profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Given("user clicks on Manage Requests tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("user clicks on Sent Requests menu option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("user navigates to Sent Requests page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
