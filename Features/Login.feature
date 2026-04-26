Feature: Login

Testing the login feature of an application

Background: 
	Given I am on the login page

@Regressiontest

Scenario: Test Login with valid credentials
	//Given I am on the login page
	When I click on the logn link
	And I enter valid <username> and <password>
	And I click on login
	Then I should be logged in successfully

	Examples: 
	| username | password |
	| user1    | pass1    |
	| user2    | pass2    |
	| user3    | pass3    |
	| user4    | pass4    |
		

	