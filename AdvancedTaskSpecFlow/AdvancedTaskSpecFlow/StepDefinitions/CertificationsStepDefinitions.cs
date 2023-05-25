using AdvancedTaskSpecFlow.Pages;
using AdvancedTaskSpecFlow.Utilities;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecFlow.StepDefinitions
{
    [Binding]
    public class CertificationsStepDefinitions : CommonDriver
    {
        LoginPage loginObject;
        Certifications certObj;
        string screenShotPath;
        public CertificationsStepDefinitions()
        {
            loginObject = new LoginPage();
            certObj = new Certifications();
            
        }

        [Given(@"I logged  into Mars application successfully")]
        public void GivenILoggedIntoMarsApplicationSuccessfully()
        {
            loginObject.LoginSteps();
        }

        [When(@"I  add '([^']*)', '([^']*)' and '([^']*)'")]
        public void WhenIAddAnd(string certificate, string certificateFrom, string year)
        {
            certObj.ClickCertification();
            certObj.CertificationSteps(certificate, certificateFrom, year);
        }

        [Then(@"Certification record should be successfully added '([^']*)' on profile page")]
        public void ThenCertificationRecordShouldBeSuccessfullyAddedOnProfilePage(string certificate)
        {
            
            string newCertText = certObj.GetCertificate();
            screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");

            
            Console.WriteLine(certificate);
            Console.WriteLine(newCertText);
            if (newCertText == certificate)
            {
                test = extentReportObj.CreateTest("Create Certifications", " Create new Certifications").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Certifications record is created successfully");
                test.Log(Status.Pass, "Test passed");
                Assert.Pass("Add Operation for Certification, Pass");
            }
            else
            {                
                test = extentReportObj.CreateTest("Create Certifications", " Create new Certifications").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Certifications record is Not created ");
                test.Log(Status.Fail, "OOPS! Add Operation Fail");

                Assert.Fail("OOPS! Add Operation Fail");
                
                
            }
        }
        
        [When(@"I update '([^']*)', '([^']*)' and '([^']*)'")]
        public void WhenIUpdateAnd(string Certificate, string CertificateFrom, string Year)
        {
            certObj.UpdateCertificateClick();

            certObj.UpdateCertificateDetails(Certificate, CertificateFrom, Year);

            certObj.UpdateCertificate();
        }

        [Then(@"Certification record should be successfully updated '([^']*)' on profile page")]
        public void ThenCertificationRecordShouldBeSuccessfullyUpdatedOnProfilePage(string certificate)
        {
            string newUpdatedCertificate = certObj.GetUpdatedCertificate();
            string screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");
            Console.WriteLine(certificate);
            Console.WriteLine(newUpdatedCertificate);

            if (newUpdatedCertificate == certificate)
            {
                test = extentReportObj.CreateTest("Update Certification", " Update the existing Certificate in profile").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Certification record is Updated successfully");
                test.Log(Status.Pass, "Update Certification Test passed");
                Assert.Pass("Update Pass");
            }
            else
            {
                test = extentReportObj.CreateTest("Update Certification", " Update the existing Certificate in profile").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Certification record is NOT Updated successfully");
                test.Log(Status.Fail, "OOPs! Update Certification Test Failed");
                Assert.Fail("OOps! Update Fail");
            }
        }


        [When(@"I delete an existing certification record '([^']*)'")]
        public void WhenIDeleteAnExistingCertificationRecord(string certificate)
        {
            certObj.DeleteCertificate(certificate);
        }

        [Then(@"The record should be  deleted and '([^']*)' should NOT be displayed in the list")]
        public void ThenTheRecordShouldBeDeletedAndShouldNOTBeDisplayedInTheList(string certificate)
        {
            string deletedCertificateText = certObj.GetDeleteCertificate();
            string screenShotPath = GetScreenShot.Capture(driver, "ScreenShotName");

            Console.WriteLine( certificate);
            Console.WriteLine( deletedCertificateText);

            if (deletedCertificateText == certificate)
            {
                test = extentReportObj.CreateTest("Delete Certification", " Delete the existing Certificate in profile").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Certification record is NOT Deleted successfully");
                test.Log(Status.Fail, "Delete Certification Test Failed");
                Assert.Fail("Record Not Deleted,Test Failed");

            }
            else
            {
                test = extentReportObj.CreateTest("Delete Certification", " Update the existing Certificate in profile").AddScreenCaptureFromPath(screenShotPath);
                test.Log(Status.Info, "Certification record is Deleted successfully");
                test.Log(Status.Pass, "Delete Certification Test passed");
                Assert.Pass("Delete Certification Test, Pass");
                Assert.Pass("Record Deleted,Test Passed");
            }
        }
    }
}
