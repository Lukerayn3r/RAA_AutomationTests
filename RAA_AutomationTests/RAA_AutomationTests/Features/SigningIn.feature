Feature: Signing In

@mytag
Scenario: Log on to website
	Given I am on the "Sign in page"
	When I click sign in
	And choose the azure portal
	And enter my credentials
	Then I should be on the "Home page"
