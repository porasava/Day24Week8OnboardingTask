Feature: 002AccountProfileEditLanguage

A short summary of the feature

Scenario Outline: TS_101_TC_001 Verify that the user edit a Languages on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	When I edit a Language with '<LanguageEdit>'
	Then Language should be Edited successfully , '<LanguageEdit>'
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel | LanguageEdit |
    | Tananya@hotmail.com | TananyaHappy | German   | Basic         | Korean       | 


Scenario Outline: TS_101_TC_002 Verify that the user edit a Languages on the account profile page with blank language field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	When I edit a Language with '<LanguageEdit>'
	Then Language should be Edited successfully , '<LanguageEdit>'
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel | LanguageEdit |
    | Tananya@hotmail.com | TananyaHappy | German   | Basic         | [SPACE]      |


	Scenario Outline: TS_101_TC_003 Verify that the user edit a Languages on the account profile page with same language field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	When I edit a Language with '<LanguageEdit>'
	Then It should show Error This language is already added to your language list.

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel | LanguageEdit |
    | Tananya@hotmail.com | TananyaHappy | German   | Basic         | German       | 


	Scenario Outline: TS_101_TC_004 Verify that the user edit a Languages level on the account profile page to be Language level
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	When I edit a Language with '<LanguageEdit>'
	Then Language should be Edited successfully , '<LanguageLevel2>'
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel | LanguageLevel2        |
    | Tananya@hotmail.com | TananyaHappy | German   | Basic         | Choose Language Level |
