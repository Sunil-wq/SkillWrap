Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add,edit and delete the education
	@mytag 
Scenario: Check if user could able to add Education
	Given I clicked on the education tab under Profile page
	When I add education details
	Then that education should be displayed on my listings
	@mytag 
Scenario: Check if user could able to update Education
	Given I clicked on the Education tab under Profile page
	When I want to edit exsisting Education
	Then that Education should be displayed on my listings
		@mytag 
Scenario: Check if user could able to delete Education 
	Given I clicked on the Education tab under Profile page
	When I want to delete exsisting Education
	Then that Education should not be be displayed on my listings
