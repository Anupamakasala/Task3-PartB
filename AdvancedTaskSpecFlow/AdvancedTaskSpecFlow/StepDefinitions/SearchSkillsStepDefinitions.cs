using AdvancedTaskSpecFlow.Pages;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using static AdvancedTaskSpecFlow.Utilities.CommonDriver;

namespace AdvancedTaskSpecFlow.StepDefinitions
{
    [Binding]
    public class SearchSkillsStepDefinitions
    {

        LoginPage loginObject;
        SearchSkill searchSkillObj;
        string screenShotPath;
        public SearchSkillsStepDefinitions()
        {
            loginObject = new LoginPage();
            searchSkillObj = new SearchSkill();

        }

        [When(@"I '([^']*)' for a skill and filter with categories")]
        public void WhenIForASkillAndFilterWithCategories(string Search1)
        {
            searchSkillObj.SearchSkillSteps(Search1);

            searchSkillObj.ClickAllCat();
            searchSkillObj.ClickCategory();
            searchSkillObj.ClickSubCategory();
        }

        [When(@"I perform another '([^']*)'  and apply filters")]
        public void WhenIPerformAnotherAndApplyFilters(string Search2)
        {
            searchSkillObj.ClickSearchSkillInner(Search2);
            
        }

        [When(@"I filter the search for a User Name '([^']*)',")]
        public void WhenIFilterTheSearchForAUserName(string User)
        {
            searchSkillObj.UserSearch(User);
            searchSkillObj.ClickRefresh();
            searchSkillObj.UserSearch(User);
            searchSkillObj.Filters();
            
        }

        

        [Then(@"I should be able to see the searched skill offered by users for transaction\.")]
        public void ThenIShouldBeAbleToSeeTheSearchedSkillOfferedByUsersForTransaction_()
        {
            screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");

            //SearchSkillObj.Message();
            string refine = searchSkillObj.VerifySearch();
            

            string BoldPt = searchSkillObj.BoldClickCategory();
            

            string BoldQa = searchSkillObj.BoldClickSubCategory();
            

            string location_Type = searchSkillObj.FilterOnline();
            

            string location_Type2 = searchSkillObj.FilterOnsite();
            

            string location_Type3 = searchSkillObj.FilterShowAll();
            

            string location_Type4 = searchSkillObj.FilterShowAll2();
            

           
            Console.WriteLine(refine);
            Console.WriteLine(BoldPt);
            Console.WriteLine(BoldQa);
            Console.WriteLine(location_Type);
            Console.WriteLine(location_Type2);
            Console.WriteLine(location_Type3);
            Console.WriteLine(location_Type4);

            

            if ((refine == "Refine Results") && (BoldPt == "400") && (BoldQa == "400") && (location_Type == "Online") && (location_Type2 == "On-Site") && (location_Type3 == "Online") && (location_Type4 == "On-Site"))
            {
                

                test = extentReportObj.CreateTest("Search a Skill", " Searching skills and applying Filters").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Searching the skills for transaction");
                test.Log(Status.Pass, "Test passed");
                Assert.Pass("Pass");
            }
            else
            {
                test = extentReportObj.CreateTest("Search a Skill", " Searching skills and applying Filters").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Searching the skills for transaction");
                test.Log(Status.Fail, "OOPs! Search Skill Test Failed");
                Assert.Fail("OOps! Test Fail");
            }
        }
    }

}
