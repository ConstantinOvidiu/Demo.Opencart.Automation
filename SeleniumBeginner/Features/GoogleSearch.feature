Feature: GoogleSearch
	I want to learn using Google
	I want to know SEO 
	I want to create my website

@loginValidForm
Scenario: Verify user Login
	Given I navigate to Google
	And I click the Login button 
	And I have entered my credentials 
	When I press submit
	Then I am successfully Logged In  


@regression
Scenario: Verify search functionality 
	Given I navigate to Google
	And I fill the search input
	When I press enter
	Then I can see the search results   