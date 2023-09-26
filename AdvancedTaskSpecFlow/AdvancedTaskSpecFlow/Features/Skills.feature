Feature: Skills

As a Seller in Mars Application
I want to Add, Update and Delete Skills (with Valid Data) in my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario Outline: 1. Add Skills on profile page
	Given I logged into the Mars application successfully
	When I add  '<skill>' and '<level>' 
	Then The skills record  '<skill>' and '<level>'  should be added successfully on profile page
	Examples:
	| skill   | level |
	| Painting | Beginner |
	| Crochet | Expert |
	
Scenario Outline: 2. Update an existing skill on profile page
	Given I logged into the Mars application successfully
	When I update'<skill>' and '<level>' 
	Then Updated '<skill>' record should be displayed on profile page 
	Examples:
	| skill   | level |
	| Dance | Beginner |
	

Scenario Outline: 3. Delete an existing skill on profile page
Given I logged into the Mars application successfully
When I delete a '<skill>' record 
Then Deleted '<skill>' record should NOT be displayed on profile page 
Examples:
| skill |
| Dance |

Scenario Outline: 4. Add Skills with Invalid details on profile page
	Given I logged into the Mars application successfully
	When I add invalid '<skill>' and '<level>' 
	Then The skills record should NOT be added and an error message '<message>' should be displayed
	Examples:
	| skill     | level     | message |
	| Painting  | Beginner  |This skill is already exist in your skill list.|
	| skillOnly |           |Please enter skill and experience level|
	|           | Beginner |Please enter skill and experience level|
	|           |           |Please enter skill and experience level|
