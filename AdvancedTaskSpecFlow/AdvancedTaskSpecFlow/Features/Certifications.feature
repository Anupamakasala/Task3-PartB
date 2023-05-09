Feature: Certifications

As a Seller in Mars Application
I want to Add, Update and Delete Certifications (with Valid Data) in  my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario: 1. Add Certificate with valid details on Profile Page 
	Given I logged  into Mars application successfully
	When  I  add '<Certificate>', '<Certificatefrom>' and '<Year>' 
	Then Certification record should be successfully added '<Certificate>' on profile page
   Examples:
	| Certificate | Certificatefrom | Year |
	| AWS        | Pearson VUE     | 2020 |
	| ISTQB		 |     ASTQB       | 2022 |

Scenario: 2. Update an existing Certification on profile page
	Given I logged  into Mars application successfully
	When  I update '<Certificate>', '<Certificatefrom>' and '<Year>'
	Then Certification record should be successfully updated '<Certificate>' on profile page 
	Examples:
	| Certificate | Certificatefrom | Year |
	|Salesforce Administrator| Salesforce     | 2015 |
	
	
Scenario: 3. Delete an existing Certification on profile page
	Given I logged  into Mars application successfully
	When I delete an existing certification record '<Certificate>'
	Then The record should be  deleted and '<Certificate>' should NOT be displayed in the list
	Examples:
	|Certificate             |
	|Salesforce Administrator|