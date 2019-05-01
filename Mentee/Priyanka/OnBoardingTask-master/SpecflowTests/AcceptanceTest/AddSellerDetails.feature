Feature: AddSellerDetails
	In order to check other sellers's skills
	As a Seller
	I want to create my Profile and search for skills


@mytag
Scenario: Check if other user could able to see seller's detail on profile page
	Given I have logged in with different user 
	And I searched for the skill under Profile Page
	And I checked the results on the search page
	When I clicked on searched profile
	Then the searched profile should be displayed