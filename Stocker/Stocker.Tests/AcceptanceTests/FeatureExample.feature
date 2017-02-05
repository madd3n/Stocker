Feature: FeatureExample

Scenario: Have a valid front end
		Given I am a normal user
		And I want to use the stock application
		When I enter the url www.stocker.com
		Then I should see the home page
		