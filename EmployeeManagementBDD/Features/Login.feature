Feature: Login

//In order to manage employee records 
/As an Admin
//I want to login to the employee dashboard
A short summary of the feature


Scenario: Valid Login

	Given I have browser with OrangeHRM application
	When I enter username as "Admin"
	And  I enter password as "admin123"
	And  I click on login
	Then I should access to portal with header as "Time at Work"

Scenario Outline: InValid Login

	Given I have browser with OrangeHRM application
	When I enter username as "<username>"
	And  I enter password as "<password>"
	And  I click on login
	Then I should get the error message as "<expected_error>"
	Examples:
	| username | password | expected_error      |
	| naga     | naga123  | Invalid Credentials |
	| syed     | syed123  | Invalid Credentials |
 

 

