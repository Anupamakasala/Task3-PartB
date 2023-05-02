Feature: This features captures all valid test cases for the below mentioned acceptance criteria

	* User is able to update the Description on the Profile page.
	* User is able to change the password on the Profile page.
	* User is able to verify Received and Sent Requests on the Manage Requests page


@Test
Scenario: verify user is able to update description details
	Given user has signed in using valid credentials
	Given user navigates to the profile tab
	Given user clicks on the pencil icon next to Description title
	When user enters text in the Description text box 
	When user clicks on the Save button
	Then Description details are saved

@Test
Scenario: verify user is able to update password
	Given user has signed in using valid credentials
	Given user navigates to the profile tab
	Given user clicks on the Hi Firstname on the top right corner
	Given user clicks on the Change Password option from the dropdown 
	When user enters Current Password, New Password, and Confirm Password 
	When user clicks on the Save button
	Then New password details are saved

@Test
Scenario: verify user is able to verify Received Requests
	Given user has signed in using valid credentials
	Given user navigates to the profile tab
	Given user clicks on Manage Requests tab
	When user clicks on Received Requests menu option
	Then user navigates to Received Requests page

@Test
 Scenario: verify user is able to verify Sent Requests
	Given user has signed in using valid credentials
	Given user navigates to the profile tab
	Given user clicks on Manage Requests tab
	When user clicks on Sent Requests menu option
	Then user navigates to Sent Requests page
