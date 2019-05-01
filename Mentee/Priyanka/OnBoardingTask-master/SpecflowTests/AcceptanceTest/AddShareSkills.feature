Feature: AddShareSkills
	In order to provide more information about my skills
	As a seller
	I want to add more skill details to my profile


@mytag
Scenario: Check if user could able to add more Skill details
	Given I clicked on the ShareSkill link under Profile page
	And I entered all the details on service listing page
	When I click on save
	Then the profile should be displayed under Manage Listings tab
