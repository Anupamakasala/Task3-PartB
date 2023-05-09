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
        SearchSkill SearchSkillObj;
        string screenShotPath;
        public SearchSkillsStepDefinitions()
        {
            loginObject = new LoginPage();
            SearchSkillObj = new SearchSkill();

        }

        [When(@"I '([^']*)' for a skill and filter with categories")]
        public void WhenIForASkillAndFilterWithCategories(string Search1)
        {
            SearchSkillObj.SearchSkillSteps(Search1);

            SearchSkillObj.ClickAllCat();
            SearchSkillObj.ClickCategory();
            SearchSkillObj.ClickSubCategory();
        }

        [When(@"I filter the search for a User Name '([^']*)',")]
        public void WhenIFilterTheSearchForAUserName(string User)
        {
            SearchSkillObj.UserSearch(User);
            SearchSkillObj.ClickRefresh();
        }

        [When(@"I perform another '([^']*)'  and apply filters")]
        public void WhenIPerformAnotherAndApplyFilters(string Search2)
        {
            SearchSkillObj.ClickSearchSkillInner(Search2);
            SearchSkillObj.Filters();
        }

        [Then(@"I should be able to see the searched skill offered by users for transaction\.")]
        public void ThenIShouldBeAbleToSeeTheSearchedSkillOfferedByUsersForTransaction_()
        {
            //SearchSkillObj.Message();
            string refine = SearchSkillObj.VerifySearch();
            string BoldPt = SearchSkillObj.BoldClickCategory();
            string BoldQa = SearchSkillObj.BoldClickSubCategory();

            Console.WriteLine(refine);
            Console.WriteLine(BoldPt);
            Console.WriteLine(BoldQa);



            if ((refine == "Refine Results")&& (BoldPt == "400") && (BoldQa == "400"))
            {

                screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");
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
