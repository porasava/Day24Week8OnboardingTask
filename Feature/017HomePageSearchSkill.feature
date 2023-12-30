Feature: 017HomePageSearchSkill

A short summary of the feature

@tag1
Scenario: TS_118_TC_063 Verify search skill text box (Beside Mars logo)
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I search a skill '<Skill>'
	Then It should display skill on the result page


	 Examples: 
    | UserName            | Password     | Skill          |
    | Tananya@hotmail.com | TananyaHappy | Graphic Design |