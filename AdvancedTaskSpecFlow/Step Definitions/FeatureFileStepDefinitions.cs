using AdvancedTaskSpecFlow.Pages;
using AdvancedTaskSpecFlow.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecFlow
{
    [Binding]
    public class FeatureFileStepDefinitions : CommonDriver
    {
        SignUp signUpObj;
        LoginPage loginPageObj;
        Notification notificationObj;

        public FeatureFileStepDefinitions()
        {

            signUpObj = new SignUp();
            loginPageObj = new LoginPage();
            notificationObj = new Notification();
        }
        //For Signup

        [Given(@"I navigate to the localhost portal")]
        public void GivenINavigateToTheLocalhostPortal()
        {
            signUpObj.Register();
        }

        [When(@"I Entered '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' for signup")]
        public void WhenIEnteredForSignup(string firstname, string lastname, string emailaddress, string password, string confirmpassword)
        {
            signUpObj.SignupCredentials(firstname, lastname, emailaddress, password, confirmpassword);
        }

        [When(@"I Click on the Checkbox menu")]
        public void WhenIClickOnTheCheckboxMenu()
        {
            signUpObj.CheckBoxButton();
        }

        [When(@"I Click on the Join Button")]
        public void WhenIClickOnTheJoinButton()
        {
            signUpObj.JoinButton();
        }

        [Then(@"I Successfully Signed up for the portal and get Signup '([^']*)' on page")]
        public void ThenISuccessfullySignedUpForThePortalAndGetSignupOnPage(string message)
        {
            string registrationSuccessfulPopUpMessage = signUpObj.GetPopUpMessage();
            Assert.That(registrationSuccessfulPopUpMessage == "Registration successful", "Actual popup message and expected popup message do not match");
        }


        //FOr Login

        [When(@"I Click on Signin Button")]
        public void WhenIClickOnSigninButton()
        {
            loginPageObj.ClickonSignin();
        }

        [When(@"I Entered '([^']*)'and'([^']*)'to login into the portal")]
        public void WhenIEnteredAndtoLoginIntoThePortal(string emailaddress, string password)
        {
            loginPageObj.Entercredentials(emailaddress, password);
        }

        [When(@"I Click on the Login Button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPageObj.LoginButton();
        }

        [Then(@"I Successfully logged into the portal and get'([^']*)' on profile page")]
        public void ThenISuccessfullyLoggedIntoThePortalAndGetOnProfilePage(string name)
        {
            string newName = loginPageObj.GetName();
            Assert.That(newName == loginPageObj.GetName(), "Actual name and expected name do not match");

        }


        //For Loadmore Notifications

        [Given(@"I Successfully logged into the portal")]
        public void GivenISuccessfullyLoggedIntoThePortal()
        {
            loginPageObj.LoginSteps();
        }

        [When(@"I clicked on the Notification dropdown menu")]
        public void WhenIClickedOnTheNotificationDropdownMenu()
        {

            notificationObj.LoadMoreNotification();
        }

        [When(@"I clicked on the See All Button")]
        public void WhenIClickedOnTheSeeAllButton()
        {
            notificationObj.SeeAll();
        }

        [Then(@"It Navigates me to the notifications page and I clicked on the LoadMore button at the bottom")]
        public void ThenItNavigatesMeToTheNotificationsPageAndIClickedOnTheLoadMoreButtonAtTheBottom()
        {
            notificationObj.LoadMore();
        }

        [Then(@"All the Notifications displayed on the page")]
        public void ThenAllTheNotificationsDisplayedOnThePage()
        {

           string ShowLessText = notificationObj.GetShowLessText();
           Assert.That(ShowLessText == "...Show Less", "Failed");

           
        }

        //For Showless Notifications 

        [When(@"I clicked on the ShowLess button at the bottom")]
        public void WhenIClickedOnTheShowLessButtonAtTheBottom()
        {
            notificationObj.LoadMore(); ;
            notificationObj.ShowLessNotification();
        }

        [Then(@"Only Few Latest notifications displayed on the page")]
        public void ThenOnlyFewLatestNotificationsDisplayedOnThePage()
        {
            string LoadMoreText = notificationObj.GetLoadMoreText();
            Assert.That(LoadMoreText == "Load More...", "Failed");

        }
    }
}
