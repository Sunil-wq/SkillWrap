Feature: SpecFlowFeature3
	In order to update my profile 
	As a skill trader
	I want to add,edit and delete the certification

	
	@mytag @automate
Scenario: Check if user could able to add Certifications
    Given I clicked on the Certification tab under Profile page 
	When I enter Certification details
	Then that Certification should be displayed on my listings

		@mytag @automate
Scenario: Check if user could able to update Certifications
	Given I clicked on the Certification tab under Profile page
	When I want to edit exsisting Certifications
	Then that Certification should be displayed on my listings

		@mytag @automate
Scenario: Check if user could able to delete Certifications
	Given I clicked on the Certification tab under Profile page
	When I want to delete exsisting Certifications
	Then that Certifications should not be be displayed on my listings




