Feature: SpecFlowMenuTest

In order to find needed documentation
As a specflow user
I want to be able to navigate pages through main menu

@smoke
Scenario Outline: Clicking menu option from the main menu should open corresponding page
	Given I open official SpecFlow website
	When I hover the '<menuItem>' menu item from the main menu
	And I click '<subMenuItem>' option from the main menu
	Then Page with '<title>' title should be opened

	Examples: 
	| menuItem | subMenuItem | title                                |
	| Docs     | SpecFlow    | Welcome to SpecFlow’s documentation! |
