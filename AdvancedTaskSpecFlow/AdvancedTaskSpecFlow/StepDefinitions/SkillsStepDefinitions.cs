using AdvancedTaskSpecFlow.Pages;
using AdvancedTaskSpecFlow.Utilities;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecFlow.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions : CommonDriver
    {
        LoginPage loginObject;
        Skills skillObj;
        string screenShotPath;
        public SkillsStepDefinitions()
        {
            loginObject = new LoginPage();
            skillObj = new Skills();
        }
    
        [Given(@"I logged into the Mars application successfully")]
        public void GivenILoggedIntoTheMarsApplicationSuccessfully()
        {
            loginObject.LoginSteps();
        }

        [When(@"I add  '([^']*)' and '([^']*)'")]
        public void WhenIAddAnd(string skill, string level)
        {
            skillObj.SkillsClick();
            skillObj.SkillsSteps(skill, level);
            skillObj.SkillsAdd();
        }

        [Then(@"The skills record  '([^']*)' and '([^']*)'  should be added successfully on profile page")]
        public void ThenTheSkillsRecordAndShouldBeAddedSuccessfullyOnProfilePage_(string skill, string level)
        {
            string newskill = skillObj.GetSkill(skill);
            string newskillLevel = skillObj.GetSkillLevel(level);

            Console.WriteLine(newskill);
            Console.WriteLine(skill);
            Console.WriteLine(newskillLevel);
            Console.WriteLine(level);

            screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");


            if ((newskill == skill) && (newskillLevel == level))
            {
                test = extentReportObj.CreateTest("Create Skills", " Create new Skills").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Skills record is created successfully");
                test.Log(Status.Pass, "Test passed");
                Assert.Pass("Skill added");
            }
            else
            {
                test = extentReportObj.CreateTest("Create Skills", " Create new Skills").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Skills record is Not created ");
                test.Log(Status.Fail, "OOPS! Add Operation Fail");
                Assert.Fail("Fail");
            }
        }

        [When(@"I update'([^']*)' and '([^']*)'")]
        public void WhenIUpdateAnd(string skill, string level)
        {
            skillObj.UpdateSkillsClick();
            skillObj.UpdateSkills(skill, level);
            skillObj.UpdateSkillsButton();
        }

        [Then(@"Updated '([^']*)' record should be displayed on profile page")]
        public void ThenUpdatedRecordShouldBeDisplayedOnProfilePage(string skill)
        {
            string newUpdatedSkill = skillObj.GetUpdatedSkill();
            //string newUpdatedSkillLevel = skillObj.GetUpdatedSkillLevel();
            screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");

            if (newUpdatedSkill == skill) 
                //&& (newUpdatedSkillLevel == level))
            {
                test = extentReportObj.CreateTest("Create Certifications", " Create new Certifications").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Certifications record is created successfully");
                test.Log(Status.Pass, "Test passed");
                Assert.Pass("Skill Updated");
            }
            else
            {
                test = extentReportObj.CreateTest("Create Skills", " Create new Skills").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Skills record is Not created ");
                test.Log(Status.Fail, "OOPS! Add Operation Fail");
                Assert.Fail("Opps Skill NOT updated");
            }
        }

        [When(@"I delete a '([^']*)' record")]
        public void WhenIDeleteARecord(string skill)
        {
            skillObj.DeleteSkills(skill);
            Thread.Sleep(3000);
        }

        [Then(@"Deleted '([^']*)' record should NOT be displayed on profile page")]
        public void ThenDeletedRecordShouldNOTBeDisplayedOnProfilePage(string skill)
        {
            string deletedSkill = skillObj.GetDeleteSkills();
            screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");

            if (deletedSkill == skill)
            {
                test = extentReportObj.CreateTest("Create Certifications", " Create new Certifications").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Certifications record is Not created ");
                test.Log(Status.Fail, "OOPS! Add Operation Fail");
                Assert.Fail("Opps Skill NOT Deleted");

            }
            else
            {
                test = extentReportObj.CreateTest("Create Skills", " Create new Skills").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Skills record is created successfully");
                test.Log(Status.Pass, "Test passed");
                Assert.Pass("Skill Deleted");
            }
        }

        [When(@"I add invalid '([^']*)' and '([^']*)'")]
        public void WhenIAddInvalidAnd(string skill, string level)
        {
            skillObj.SkillsClick();
            skillObj.SkillsSteps(skill, level);
            skillObj.SkillsAdd();
        }

        

        [Then(@"The skills record should NOT be added and an error message '([^']*)' should be displayed")]
        public void ThenTheSkillsRecordShouldNOTBeAddedAndAnErrorMessageShouldBeDisplayed(string message)
        {
            string invalidSkillText = skillObj.InvalidSkills();
            screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");


            Console.WriteLine(message);
            Console.WriteLine(invalidSkillText);

            if (invalidSkillText == message)
            {
                test = extentReportObj.CreateTest("Invalid Certifications", " Test for invalid certifications data").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Correct message");
                test.Log(Status.Pass, "Test passed");
                Assert.Pass("Correct message is displayed, Test Pass");
            }
            else
            {
                test = extentReportObj.CreateTest("Invalid Certifications", " Test for invalid certifications data").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Not a correct message ");
                test.Log(Status.Fail, "OOPS! Test Fail");

                Assert.Fail("OOPS! Not a correct message, Test Fail");


            }
        }





    }
}
