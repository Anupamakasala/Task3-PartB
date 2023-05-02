using System;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using AdvancedTaskSpecFlow.Pages;

namespace AdvancedTaskSpecFlow.StepDefinitions
{
    [Binding]
    public class ValidTestCasesStepDefinitions
    {

        // open chrome browser
        ChromeDriver driver = new ChromeDriver();

        // page object creation
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"user has signed in using valid credentials")]
        public void GivenUserHasSignedInUsingValidCredentials()
        {
            loginPageObj.LoginSteps(driver);

        }

        [Given(@"user navigates to the profile tab")]
        public void GivenUserNavigatesToTheProfileTab()
        {
            profilePageObj.VerifyProfilePage(driver);

        }

        [Given(@"user clicks on the pencil icon next to Description title")]
        public void GivenUserClicksOnThePencilIconNextToDescriptionTitle()
        {
            profilePageObj.ClickOnPencilIconNextToDescriptionField(driver);

        }

        [When(@"user enters text in the Description text box")]
        public void WhenUserEntersTextInTheDescriptionTextBox()
        {
            profilePageObj.EnterTextInDescriptionTextBox(driver);

        }

        [When(@"user clicks on the Save button")]
        public void WhenUserClicksOnTheSaveButton()
        {
            profilePageObj.ClickOnTheSaveButton(driver);

        }

        [Then(@"Description details are saved")]
        public void ThenDescriptionDetailsAreSaved()
        {
            profilePageObj.DescriptionDetailsSaved(driver);

        }

        [Given(@"user clicks on the Hi Firstname on the top right corner")]
        public void GivenUserClicksOnTheHiFirstnameOnTheTopRightCorner()
        {
            profilePageObj.ClickOnHiFirstName(driver);

        }

        [Given(@"user clicks on the Change Password option from the dropdown")]
        public void GivenUserClicksOnTheChangePasswordOptionFromTheDropdown()
        {
            profilePageObj.ClickOnChangePassword(driver);

        }

        [When(@"user enters Current Password, New Password, and Confirm Password")]
        public void WhenUserEntersCurrentPasswordNewPasswordAndConfirmPassword()
        {
            profilePageObj.EnterCurrentPasswordNewPasswordConfirmPassword(driver);

        }

        [Then(@"New password details are saved")]
        public void ThenNewPasswordDetailsAreSaved()
        {
            profilePageObj.NewPasswordDetailsSaved(driver);

        }

        [Given(@"user clicks on Manage Requests tab")]
        public void GivenUserClicksOnManageRequestsTab()
        {
            profilePageObj.ClickOnManageRequestsTab(driver);

        }

        [When(@"user clicks on Received Requests menu option")]
        public void WhenUserClicksOnReceivedRequests()
        {
            profilePageObj.ClickOnReceivedRequests(driver);

        }

        [Then(@"user navigates to Received Requests page")]
        public void ThenUserNavigatesToReceivedRequestsPage()
        {
            profilePageObj.VerifyReceivedRequestsPage(driver);

        }

        [When(@"user clicks on Sent Requests menu option")]
        public void WhenUserClicksOnSentRequests()
        {
            profilePageObj.ClickOnSentRequests(driver);

        }

        [Then(@"user navigates to Sent Requests page")]
        public void ThenUserNavigatesToSentRequestsPage()
        {
            profilePageObj.VerifySentRequestsPage(driver);

        }
    }
}
