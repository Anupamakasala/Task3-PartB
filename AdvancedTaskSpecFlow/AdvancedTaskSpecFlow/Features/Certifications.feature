Feature: Certifications

As a Seller in Mars Application
I want to Add, Update and Delete Certifications (with Valid Data) in  my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario Outline: 1. Add Certificate with valid details on Profile Page 
	Given I logged  into Mars application successfully
	When  I  add '<Certificate>', '<Certificatefrom>' and '<Year>' 
	Then Certification record should be successfully added '<Certificate>' on profile page
   Examples:
	| Certificate | Certificatefrom | Year |
	| AWS        | Pearson VUE      | 2020 |
	| ISTQB		 |     ASTQB        | 2022 |	

Scenario Outline: 2. Update an existing Certification on profile page
	Given I logged  into Mars application successfully
	When  I update '<Certificate>', '<Certificatefrom>' and '<Year>'
	Then Certification record should be successfully updated '<Certificate>' on profile page 
	Examples:
	| Certificate | Certificatefrom | Year |
	|Salesforce Administrator| Salesforce     | 2015 |
	
	
Scenario Outline: 3. Delete an existing Certification on profile page
	Given I logged  into Mars application successfully
	When I delete an existing certification record '<Certificate>'
	Then The record should be  deleted and '<Certificate>' should NOT be displayed in the list
	Examples:
	|Certificate             |
	|Salesforce Administrator|

Scenario Outline: 4. Add Certificate with invalid details on Profile Page 
	Given I logged  into Mars application successfully
	When  I add invalid '<Certificate>', '<Certificatefrom>' and '<Year>' 
	Then Certification record should NOT be added and an error message '<message>' should be displayed
   Examples:
	| Certificate | Certificatefrom | Year | message                                                                    |
	| AWS         | Pearson VUE     | 2020 | This information is already exist.                                          |
	|             | FromOnly        | 2020 | Please enter Certification Name, Certification From and Certification Year |
	| CertOnly    |                 | 2020 | Please enter Certification Name, Certification From and Certification Year |
	|             |                 | 2020 | Please enter Certification Name, Certification From and Certification Year |
	|             |                 |      | Please enter Certification Name, Certification From and Certification Year |

