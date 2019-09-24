Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add,edit and delete the language,skills,education,certification

@mytag @automate
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

	@mytag @automate
Scenario: Check if user could able to update language 
	Given I clicked on the Language tab under Profile page
	When I want to edit exsisting language
	Then that language should be displayed on my listings
		@mytag @automate
Scenario: Check if user could able to delete language 
	Given I clicked on the Language tab under Profile page
	When I want to delete exsisting language
	Then that language should not be be displayed on my listings
	
	@mytag @automate
Scenario: Check if user could able to add a new skill 
	Given I clicked on the skill tab under Profile page
	When I add a new skill
	Then that skill should be displayed on my listings
	
		@mytag @automate
Scenario: Check if user could able to add Education
	Given I clicked on the education tab under Profile page
	When I add education details
	Then that education should be displayed on my listings

	@mytag @automate
Scenario: Check if user could able to add Certifications
	Given I clicked on the certification tab under Profile page
	When I enter certification details
	Then that certification details should be displayed on my listings