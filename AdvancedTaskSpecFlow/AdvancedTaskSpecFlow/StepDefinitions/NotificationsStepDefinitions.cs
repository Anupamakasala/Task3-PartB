using AdvancedTaskSpecFlow.Pages;
using AdvancedTaskSpecFlow.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecFlow.StepDefinitions
{
    [Binding]
    public class NotificationsStepDefinitions:CommonDriver
    {
        Notifications notificationObj = new Notifications();

        [When(@"User navigates to the notification page")]
        public void WhenUserNavigatesToTheNotificationPage()
        {
            notificationObj.GoToNotification();
        }

        [When(@"User uses the mark as read option")]
        public void WhenUserUsesTheMarkAsReadOption()
        {
            notificationObj.MarkAsRead();
        }

        [Then(@"All the notification should be marked as read")]
        public void ThenAllTheNotificationShouldBeMarkedAsRead()
        {
            string testResult = notificationObj.GetNotification();
            Assert.That(testResult == "400", "Test failed");
        }

        [Given(@"User is in the notification page")]
        public void GivenUserIsInTheNotificationPage()
        {
            notificationObj.GoToNotification();
        }


        [When(@"User selects all the notification and deletes")]
        public void WhenUserSelectsAllTheNotificationAndDeletes()
        {
            notificationObj.DeleteNotification();
        }


        [Then(@"User is not able to see the notification any longer")]
        public void ThenUserIsNotAbleToSeeTheNotificationAnyLonger()
        {
            string deletenotificationText = notificationObj.GetDeletedNotification();
            Assert.That(deletenotificationText == "You have no notifications", "Test failed");
        }
    }
}
