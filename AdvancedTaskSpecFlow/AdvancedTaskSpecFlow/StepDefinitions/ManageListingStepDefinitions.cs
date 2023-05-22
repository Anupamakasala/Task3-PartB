using AdvancedTaskSpecFlow.Pages;
using AdvancedTaskSpecFlow.Utilities;
using NUnit.Framework;
using System;
using System.Net.Mail;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecFlow.StepDefinitions
{
    [Binding]
    public class ManageListingStepDefinitions: CommonDriver
    {
        ManageListing managelistingObj = new ManageListing();

       
        [When(@"User navigates to the manage listing page")]
        public void WhenUserNavigatesToTheManageListingPage()
        {
            managelistingObj.GoToManageListing();

        }

       
        [When(@"User updates the service lisitng with '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void WhenUserUpdatesTheServiceLisitngWith(string title, string addtags, string skilltags, string skilltrade, string charge)
        {
            managelistingObj.EditListing(title, addtags, skilltrade, skilltags, charge);
        }

 

        
        [Then(@"user should be able to see the changes made")]
        public void ThenUserShouldBeAbleToSeeTheChangesMade()
        {
            string editmanagelisitngtest = managelistingObj.GetEditedManageListing();

            Assert.That(editmanagelisitngtest == "All ages Ballet Dancer", "Service listing not updated");

        }
    }
}
