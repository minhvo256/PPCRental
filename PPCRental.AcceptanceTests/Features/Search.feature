Feature: Search
	I want to search for a project with keywords
@mytag
Scenario: search project
	Given I access to PPC Rental Website
	When I press search button
	And I fill the keyword field with the keyword i want to search
	And I press on search button
	Then the result should be project list
