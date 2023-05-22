using AdvancedTaskSpecFlow.Pages;
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecFlow.StepDefinitions
{
    [Binding]
    public class ShareSkillStepDefinitions
    {
        ShareSkill shareskillObj = new ShareSkill();

        [When(@"I navigate to the share skill page")]
        public void WhenINavigateToTheShareSkillPage()
        {
            shareskillObj.GoToShareSkill();
        }

        [When(@"I add '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'to the page and save it")]
        public void WhenIAddToThePageAndSaveIt(string title, string description, string category, string subcategory, string addtags, 
                                               string servicetype, string locationtype, string daysavailable, string beginDate, string finishDate, 
                                               string starttime, string endtime, string skilltrade, string skilltags, string charge, string active)
        {
            shareskillObj.AddShareSkill(title, description, category, subcategory, addtags, servicetype, locationtype, daysavailable, beginDate,
                                    finishDate, starttime, endtime, skilltrade, skilltags, charge, active);
            
        }

        [Then(@"I should be able to see the skill listed")]
        public void ThenIShouldBeAbleToSeeTheSkillListed()
        {
            string shareskillTest = shareskillObj.GetManageListing();
            Assert.That(shareskillTest == "Ballet Dancer", "Listing not found");
        }
    }
}
