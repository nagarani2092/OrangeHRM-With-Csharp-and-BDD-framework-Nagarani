Feature: Employee

//In order to manage employee records 
/As an Admin
//I want to add, edit, delete employee details

Scenario: Add Valid Employee Record
    Given I have browser with OrangeHRM application
	When I enter username as "Admin"
	And  I enter password as "admin123"
	And  I click on login
	And I click on PIM menu
	And I click on  Add Employee menu
	And I fill the employee form
	| firstname | middlename | lastname |
	| john      | w          | wick     |
	And I click on save employee
	Then i should get the profile name as "jack wick"
	And I should get all field with filld data
	


