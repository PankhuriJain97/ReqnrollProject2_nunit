Feature: CreateUser

To Test the Create new user functionality

Background: 
	Given I navigate to http://eaapp.somee.com/

@Regressiontest
Scenario: Create a new user
	When I click on the register link
	And I enter user details as follows :
		| Username | Email Address	   | Password | Confirm Password |
		| user1    | user1@example.com | pass1	  | pass1			 |
		| user2    | user2@example.com | pass2	  | pass2			 |
		| user3    | user3@example.com | pass3	  | pass3			 |
	
	And I click on Create Account button
	Then I should be registered successfully


Scenario: Create a new user with dynamic data table
	When I click on the register link
	And I enter user details with dynamic data table as follows :
		| Username | Email Address     | Password | Confirm Password |
		| user1    | user1@example.com | pass1    | pass1            |
		| user2    | user2@example.com | pass2    | pass2            |

	And I click on Create Account button
	Then I should be registered successfully


