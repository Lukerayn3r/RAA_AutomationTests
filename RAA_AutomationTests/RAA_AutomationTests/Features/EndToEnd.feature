Feature: End To End

@mytag
Scenario: End to end journey of RAA application
	Given I am on the "Sign in page"
	When I click sign in
	And choose the azure portal
	And enter my credentials
	Then I should be on the "Home page"
	When I create a new vacancy
