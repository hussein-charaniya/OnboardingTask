Feature: ProfileLanguage

The purpose of this file is to check if the user can Add, Edit, And Delete the Language record in profile successfully.


Scenario: I would liketo add Language record for profile detail
	Given Login to th portal successfully
	And   Navigate to The language via profile tab
	When  Add a New language in the profile
	Then  Profile skill was created successfully

Scenario: I would like to Edit Language record for profile detail
	Given Login to th portal successfully
	And   Navigate to the language via profile tab
	When  Edit a New language in profile
	Then  Profile skill was successfully Edited

	Scenario: Delete Language record for profile detail
	Given Login to th portal successfully
	And   Navigate to the language via profile tab
	When  Delete a New language in the profile
	Then  Profile skill was Deleted successfully


