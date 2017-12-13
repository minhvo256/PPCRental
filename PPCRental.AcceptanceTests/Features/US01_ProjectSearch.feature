Feature: US01_ProjectSearch
	As a customer
	I want to search for projects by a keyword
	So that I can easily search projects by keyword name of projects 


    Scenario: Simple search
	Given I access to PPC Rental Website
	When I press search button
	And I search for projects by the keyword 'Top'
	And I press on search button
	Then the list of found projects should contain only: 'PIS Top Apartment'
	
	


		


	


