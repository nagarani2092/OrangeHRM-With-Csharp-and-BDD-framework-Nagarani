Feature: Employee

//In order to manage employee records 
/As an Admin
//I want to add, edit, delete employee details

Scenario Outline: Add Valid Employee Record
    Given I have browser with OrangeHRM application
	When I enter username as "Admin"
	And  I enter password as "admin123"
	And  I click on login
	And I click on PIM menu
	And I click on  Add Employee menu
	And I fill the employee form
	| firstname | middlename    | lastname |
	| <fname>   | <middle_name> | <lname>  |
	And I click on save employee
	Then i should get the profile name as "<fname> <lname>"
	And I should get all field with filld data
	Examples:
	| username | password | fname | middle_name | lname   |
	| Admin    | admin123 | saul  | G           | goodman |
	#| Admin    | admin123 | john  | w           | wick    |


