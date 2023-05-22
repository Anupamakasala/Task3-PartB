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
    [NUnit.Framework.DescriptionAttribute("ShareSkill")]
    public partial class ShareSkillFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ShareSkill.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ShareSkill", "User should add their skills on to the share skill page so that they can list and" +
                    " trade skills", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestCaseAttribute("Ballet Dancer", "I am a ballet dancer", "Fun & Lifestyle", "Health, Nutrition & Fitness", "Dance", "Hourly basis service", "On-site", "Mon", "10102023", "10102024", "0900", "1230", "Skill-exchange", "SQL Server", "0", "Active", null, TestName=@"AddSkillsOnTheShareSkillPageAndBeAbleToSaveSkills with ""Ballet Dancer"", ""I am a ballet dancer"", ""Fun & Lifestyle"", ""Health, Nutrition & Fitness"", ""Dance"", ""Hourly basis service"", ""On-site"", ""Mon"", ""10102023"", ""10102024"", ""0900"", ""1230"", ""Skill-exchange"", ""SQL Server"", ""0"", ""Active""")]
        public virtual void AddSkillsOnTheShareSkillPageAndBeAbleToSaveSkills(
                    string title, 
                    string description, 
                    string category, 
                    string subcategory, 
                    string addtags, 
                    string serviceType, 
                    string locationtype, 
                    string daysavailable, 
                    string begindate, 
                    string finishdate, 
                    string starttime, 
                    string endtime, 
                    string skilltrade, 
                    string skilltags, 
                    string charge, 
                    string active, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Title", title);
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("Category", category);
            argumentsOfScenario.Add("Subcategory", subcategory);
            argumentsOfScenario.Add("Addtags", addtags);
            argumentsOfScenario.Add("ServiceType", serviceType);
            argumentsOfScenario.Add("Locationtype", locationtype);
            argumentsOfScenario.Add("Daysavailable", daysavailable);
            argumentsOfScenario.Add("Begindate", begindate);
            argumentsOfScenario.Add("Finishdate", finishdate);
            argumentsOfScenario.Add("Starttime", starttime);
            argumentsOfScenario.Add("Endtime", endtime);
            argumentsOfScenario.Add("Skilltrade", skilltrade);
            argumentsOfScenario.Add("Skilltags", skilltags);
            argumentsOfScenario.Add("Charge", charge);
            argumentsOfScenario.Add("Active", active);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add skills on the share skill page and be able to save skills", null, @__tags, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.When("I navigate to the share skill page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And(string.Format("I add \'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\',\'<Servicetype>\',\'{5}\',\'{6}\',\'<BeginDate>\',\'<F" +
                        "inishDate>\',\'{7}\',\'{8}\',\'{9}\',\'{10}\',\'{11}\',\'{12}\'to the page and save it", title, description, category, subcategory, addtags, locationtype, daysavailable, starttime, endtime, skilltrade, skilltags, charge, active), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be able to see the skill listed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
