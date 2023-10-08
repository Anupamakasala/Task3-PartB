Feature: Feature File

A short summary of the feature

@tag1

Scenario Outline: 01) Signup for the Localhost
    Given I navigate to the localhost portal 
	When I Entered '<Firstname>','<Lastname>','<Emailaddress>','<Password>','<ConfirmPassword>' for signup 
	And I Click on the Checkbox menu
	And I Click on the Join Button
	Then I Successfully Signed up for the portal and get Signup '<Message>' on page

Examples: 
| Firstname | Lastname | Emailaddress      | Password | ConfirmPassword |
| Akash     | Rana     | Akash11@gmail.com | Akash11  | Akash11         |
| Anshu     | Rana     | Anshu11@gmail.com | Anshu11  | Anshu11         |
| Ayra      | Rana     | Ayra11@gmail.com  | Ayra11   | Ayra11          |


Scenario Outline: 02) Login into the localhost
    When  I Click on Signin Button
	When I Entered '<Emailaddress>'and'<Password>'to login into the portal
	And I Click on the Login Button
	Then I Successfully logged into the portal and get'<Name>' on profile page

Examples: 
| Emailaddress    | Password    | Name     |
| Akash11@gmail.com | Akash11   | Hi Akash |
| Anshu11@gmail.com | Anshu11   | Hi Anshu |
| Ayra11@gmail.com  | Ayra11    | Hi Ayra  |


Scenario: 03) Load More Notifications under the Notification Menu
    Given  I Successfully logged into the portal 
    When  I clicked on the Notification dropdown menu
    And  I clicked on the See All Button
    Then  It Navigates me to the notifications page and I clicked on the LoadMore button at the bottom
    Then  All the Notifications displayed on the page

Scenario:  Show Less Notifications under the Notification Menu
    Given  I Successfully logged into the portal
    When I clicked on the Notification dropdown menu
    And I clicked on the See All Button
    When I clicked on the ShowLess button at the bottom
    Then Only Few Latest notifications displayed on the page




