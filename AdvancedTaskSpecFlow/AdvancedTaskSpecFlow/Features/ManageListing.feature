Feature: ManageListing

User should be able to edit and delete the service listing added to the page

@tag1
Scenario Outline: Edit Manage listing
	When User navigates to the manage listing page
	And User updates the service lisitng with '<Title>','<Addtags>','<Skilltrade>','<Skilltags>','<charge>'
	Then user should be able to see the changes made
	Examples: 
	| Title                  | Addtags    | Skilltrade | Skilltags | Charge |
	| All ages Ballet Dancer | Exercising | Credit     |           | 10     |
	
	


