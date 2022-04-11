Feature: ProfileLanguage

The purpose of this file is to check if the user can Add, Edit, And Delete the Language record in profile successfully.


Scenario: I would like to add Language record for profile detail
	Given Login to the portal successfully
	And   Navigate to language via profile tab
	When  Add a New language in profile
	Then  Profile skill was successfully created
