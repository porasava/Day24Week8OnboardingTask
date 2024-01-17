Feature: 006AccountProfileDeleteSkill

A short summary of the feature

Scenario Outline: TS_203_TC_001 Verify that the user delete a skill on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I delete a skill with '<SkillDelete>'
	Then The skill should delete successfully
	
	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Creativity    | Expert     | Creativity  |