Feature: SearchSkills

As a User in Mars Application
I want to Search a Skill
So that
I can see the skills offered by others users for transaction.

@tag1
Scenario: Search a skill and apply filters
	Given I logged  into Mars application successfully
	When I '<Search1>' for a skill and filter with categories
	And I perform another '<Search2>'  and apply filters 
	And I filter the search for a User Name '<User>',
	
	Then I should be able to see the searched skill offered by users for transaction.
	Examples:
	| Search1 | User | Search2 |
	| Selenium |Pooja Saini| Testing |