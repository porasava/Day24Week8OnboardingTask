Feature: 005AccountProfileEditSkill

A short summary of the feature

Scenario Outline: TS_202_TC_001 Verify that the user edit a skill on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I edit a skill with '<SkillEdit>'
	Then The skill should edit successfully
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillEdit | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Communication | Expert     | Teamwork  | Teamwork    |


Scenario Outline: TS_202_TC_002 Verify that the user edit a skill on the account profile page with blank skill field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I edit a skill with '<SkillEdit>'
	Then The skill should edit successfully
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillEdit | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Communication | Expert     | Teamwork  | Teamwork    |


Scenario Outline: TS_202_TC_003 Verify that the user edit a skill on the account profile page with same skill field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I edit a skill with '<SkillEdit>'
	Then The skill should edit successfully
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillEdit | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Communication | Expert     | Teamwork  | Teamwork    |


Scenario Outline: TS_202_TC_004 Verify that the user edit a skill level on the account profile page to be skill level
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I edit a skill with '<SkillEdit>'
	Then The skill should edit successfully
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillEdit | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Communication | Expert     | Teamwork  | Teamwork    |

