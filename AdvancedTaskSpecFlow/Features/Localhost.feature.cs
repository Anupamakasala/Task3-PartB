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
    [NUnit.Framework.DescriptionAttribute("Feature File")]
    public partial class FeatureFileFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Localhost.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Feature File", "A short summary of the feature", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestCaseAttribute("Akash", "Rana", "Akash11@gmail.com", "Akash11", "Akash11", null, TestName="_01SignupForTheLocalhost with \"Akash\", \"Rana\", \"Akash11@gmail_com\", \"Akash11\", \"A" +
            "kash11\"")]
        [NUnit.Framework.TestCaseAttribute("Anshu", "Rana", "Anshu11@gmail.com", "Anshu11", "Anshu11", null, TestName="_01SignupForTheLocalhost with \"Anshu\", \"Rana\", \"Anshu11@gmail_com\", \"Anshu11\", \"A" +
            "nshu11\"")]
        [NUnit.Framework.TestCaseAttribute("Ayra", "Rana", "Ayra11@gmail.com", "Ayra11", "Ayra11", null, TestName="_01SignupForTheLocalhost with \"Ayra\", \"Rana\", \"Ayra11@gmail_com\", \"Ayra11\", \"Ayra" +
            "11\"")]
        public virtual void _01SignupForTheLocalhost(string firstname, string lastname, string emailaddress, string password, string confirmPassword, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Firstname", firstname);
            argumentsOfScenario.Add("Lastname", lastname);
            argumentsOfScenario.Add("Emailaddress", emailaddress);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("ConfirmPassword", confirmPassword);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01) Signup for the Localhost", null, @__tags, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("I navigate to the localhost portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When(string.Format("I Entered \'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\' for signup", firstname, lastname, emailaddress, password, confirmPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I Click on the Checkbox menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("I Click on the Join Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I Successfully Signed up for the portal and get Signup \'<Message>\' on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestCaseAttribute("Akash11@gmail.com", "Akash11", "Hi Akash", null, TestName="_02LoginIntoTheLocalhost with \"Akash11@gmail_com\", \"Akash11\", \"Hi Akash\"")]
        [NUnit.Framework.TestCaseAttribute("Anshu11@gmail.com", "Anshu11", "Hi Anshu", null, TestName="_02LoginIntoTheLocalhost with \"Anshu11@gmail_com\", \"Anshu11\", \"Hi Anshu\"")]
        [NUnit.Framework.TestCaseAttribute("Ayra11@gmail.com", "Ayra11", "Hi Ayra", null, TestName="_02LoginIntoTheLocalhost with \"Ayra11@gmail_com\", \"Ayra11\", \"Hi Ayra\"")]
        public virtual void _02LoginIntoTheLocalhost(string emailaddress, string password, string name, string[] exampleTags)
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Emailaddress", emailaddress);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Name", name);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02) Login into the localhost", null, exampleTags, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("I navigate to the localhost portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I Click on Signin Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And(string.Format("I Entered \'{0}\'and\'{1}\'to login into the portal", emailaddress, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("I Click on the Login Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then(string.Format("I Successfully logged into the portal and get\'{0}\' on profile page", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03) Load More Notifications under the Notification Menu")]
        public virtual void _03LoadMoreNotificationsUnderTheNotificationMenu()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03) Load More Notifications under the Notification Menu", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("I Successfully logged into the portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I clicked on the Notification dropdown menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I clicked on the See All Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("It Navigates me to the notifications page and I clicked on the LoadMore button at" +
                    " the bottom", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("All the Notifications displayed on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Show Less Notifications under the Notification Menu")]
        public virtual void ShowLessNotificationsUnderTheNotificationMenu()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Show Less Notifications under the Notification Menu", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("I Successfully logged into the portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I clicked on the Notification dropdown menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I clicked on the See All Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("I clicked on the ShowLess button at the bottom", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Only Few Latest notifications displayed on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
