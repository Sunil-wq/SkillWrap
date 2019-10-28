﻿Feature: SpecFlowFeature2
	In order to update my profile 
	As a skill trader
	I want to add,edit and delete the skills

@mytag @automate
Scenario: Check if user could able to add a new skill 
	Given I clicked on the skill tab under Profile page
	When I add a new skill
	Then that skill should be displayed on my listings

	@mytag @automate
Scenario: Check if user could able to update skill 
	Given I clicked on the skill tab under Profile page
	When I want to edit exsisting skill
	Then that skill should be displayed on my listings

		@mytag @automate
Scenario: Check if user could able to delete skill
	Given I clicked on the skill tab under Profile page
	When I want to delete exsisting skill
	Then that skill should not be be displayed on my listings
