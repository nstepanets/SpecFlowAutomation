Feature: SpecFlowMenuTest

In order to find needed documentation
As a specflow user
I want to be able to navigate pages through main menu

@smoke
Scenario: Clicking Getting Started option from the main menu should open Getting Started page
	Given I open official SpecFlow website
	When I hover the 'Docs' menu item from the main menu
	And I click 'Step-by-step getting started guides' option from the main menu
	Then Page with 'Getting Started' title should be opened
