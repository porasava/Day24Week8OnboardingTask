Feature: 001AccountProfileAddLanguage

Validate that the user able to add Languages to Account profile


	Scenario Outline: TS_100_TC_001 Verify that the user add a new Languages on the account profile page with correct mandatory
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	Then Language should be add successfully' <Language>', and '<LanguageLevel>'
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel |
    | Tananya@hotmail.com | TananyaHappy | Spanish  | Basic        |



	Scenario Outline: TS_100_TC_002 Verify that the user add a new Languages on the account profile page with incorrect mandatory
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	Then It should show error Please enter language and level


	 Examples: 
    | UserName            | Password     | Language | LanguageLevel |
    | Tananya@hotmail.com | TananyaHappy | Arabic   |               |


	Scenario Outline: TS_100_TC_003 Verify that the user add a new Languages on the account profile page with space on Add Language field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel |
    | Tananya@hotmail.com | TananyaHappy | [SPACE]  | Basic         |


	Scenario Outline: TS_100_TC_004 Verify that the user add a new Languages on the account profile page with special character on Add Language field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	Then Language should be add successfully' <Language>', and '<LanguageLevel>'
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel |
    | Tananya@hotmail.com | TananyaHappy | !!!      | Basic         |


	Scenario Outline: TS_100_TC_005 Verify that the user add a new Languages on the account profile page with over 50 characters on Add Language field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	Then Language should be add successfully' <Language>', and '<LanguageLevel>'
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language                                                 | LanguageLevel |
    | Tananya@hotmail.com | TananyaHappy | SpanishSpanishSpanishSpanishSpanishSpanishSpanishSpanish | Basic         |


	Scenario Outline: TS_100_TC_006 Verify that the user add a new Languages on the account profile page with duplicate on Add Language field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	Then Language should be add successfully' <Language>', and '<LanguageLevel>'
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on add Language
	Then It should show error This language is already exist in your language list
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel |
    | Tananya@hotmail.com | TananyaHappy | Spanish  | Basic        |

	
	Scenario Outline: TS_100_TC_008 Verify that the user add new 4 Languages on the account profile page with a paragraph on Add Language field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language1>', and '<LanguageLevel>'
	Then User click on add Language
	When I add new Language with '<Language2>', and '<LanguageLevel>'
	Then User click on add Language
	When I add new Language with '<Language3>', and '<LanguageLevel>'
	Then User click on add Language
	When I add new Language with '<Language4>', and '<LanguageLevel>'
	Then Add Language button should be gone
	Then Remove Language
	Then Remove Language
	Then Remove Language
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language1 | LanguageLevel | Language2 | Language3 | Language4 |
    | Tananya@hotmail.com | TananyaHappy | Spanish   | Basic         | English   | Chinese   | Dutch     |


	Scenario Outline: TS_100_TC_009 Verify that the user click on cancel button on language tab 
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then User click on cancel


	 Examples: 
    | UserName            | Password     | Language |
    | Tananya@hotmail.com | TananyaHappy | Spanish  |
