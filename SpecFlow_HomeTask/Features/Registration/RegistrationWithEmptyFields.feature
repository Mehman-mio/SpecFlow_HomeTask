Feature: RegistrationWithEmptyFields
	In order to avoid missing empty fields while registration
	As a user
	I want to be informed about them

@negative
Scenario: Warning messages about missing mandatory fields while registration
	Given My registration page is opened
	When I have not filled in any mandatory field
	And I have clicked the confirm button
	Then displayed warning message about empty First Name field
    And displayed warning message about empty Second Name field
	And displayed warning message about empty Email field
	And displayed warning message about empty Phone Number field
	And displayed warning message about empty Adress field
	And displayed warning message about empty City field
	And displayed warning message about empty Region field
	And displayed warning message about empty Password field
