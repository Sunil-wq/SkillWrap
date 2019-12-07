Feature: Certifications
	In order to update my profile 
	As a skill trader
	I want to add,edit and delete the certification

	
	@mytag @automate
Scenario: Check if user could able to add Certifications
    Given I click on the Certification tab under Profile page
	When I enter Certifications detail
	Then that Certification detail should be displayed on my listings

		@mytag @automate
Scenario: Check if user could able to update Certifications
	Given I click on the Certification tab under Profile page
	When I want to update exsisting Certifications
	Then that updated Certification detail should be displayed on my listings

		@mytag @automate
Scenario: Check if user could able to delete Certifications
	Given I click on the Certification tab under Profile page
	When I want to delete the exsisting Certifications
	Then that Certification detail should not be be displayed on my listings




