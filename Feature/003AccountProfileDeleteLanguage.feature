Feature: 003AccountProfileDeleteLanguage.feature

A short summary of the feature

Scenario Outline: TS_103_TC_001 Verify that the user delete a Languages on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	When I delete a Language '<LanguageDelete>'
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel | LanguageDelete |
    | Tananya@hotmail.com | TananyaHappy | French   | Fluent        | French         |
