Feature: Notifications

User should be able to use the mark as read and delete notification options

@tag1
Scenario: User should be able to use the mark as read option
	When User navigates to the notification page
	And User uses the mark as read option
	Then All the notification should be marked as read

Scenario: User should be able to delete all the notification
	Given User is in the notification page
	When User selects all the notification and deletes
	Then User is not able to see the notification any longer
