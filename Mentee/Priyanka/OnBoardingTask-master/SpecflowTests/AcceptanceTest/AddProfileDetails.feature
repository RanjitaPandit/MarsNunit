Feature: AddProfileDetails
	In order to update my profile 
	As a seller
	I want to add details to my Profile 

@mytag
Scenario: Check if user could able to add a skill 
	Given I clicked on the Profile link after logged in
	And I clicked on the skills tab under Profile page
	When I add a new skill
	Then that skill should be displayed on my listings

@mytag
Scenario: Check if user could able to add Education 
	Given I clicked on the Profile link after logged in
	And I clicked on the Education tab under Profile page
	When I add Education details
	Then that Education details should be displayed on my listings


@mytag
Scenario: Check if user could able to add Certification 
	Given I clicked on the Profile link after logged in
	And I clicked on the Certifications tab under Profile page
	When I add Certification details
	Then that Certification detail should be displayed on my listings


@mytag
Scenario: Check if user could able to add Description 
	Given I clicked on the Profile link after logged in
	And I clicked on the Description link under Profile page
	When I add Description details
	Then that Description detail should be displayed on my listings


@mytag
Scenario: Check if user could able to more details in left panel 
	Given I clicked on the Profile link after logged in
	When I add more details in left panel fields
	Then that detail should be displayed on my listings