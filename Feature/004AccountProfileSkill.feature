Feature: AccountProfileSkill

A short summary of the feature

Scenario Outline: TS_201_TC_001 Verify that the user add a skill on the account profile page  with correct mandatory
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show new Skill 
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Management | Expert     | Management  |


	Scenario Outline: TS_201_TC_002 Verify that the user add a skill on the account profile page  with incorrect mandatory
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show error Please enter skill and experience level

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel |
    | Tananya@hotmail.com | TananyaHappy | Leadership |            |


	Scenario Outline: TS_201_TC_003 Verify that the user add a new skill on the account profile page with space on Add skill field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show new Skill 
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Management | Expert     | Management  |


	Scenario Outline: TS_201_TC_004 Verify that the user add a new skill on the account profile page with special character on Add skill field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show new Skill 
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Management | Expert     | Management  |

	Scenario Outline: TS_201_TC_005 Verify that the user add a new skill on the account profile page with over 50 characters on Add skill field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show new Skill 
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Management | Expert     | Management  |


	Scenario Outline: TS_201_TC_006 Verify that the user add a new skill on the account profile page with duplicate on Add skill field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show new Skill 
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Management | Expert     | Management  |


	Scenario Outline: TS_201_TC_007 Verify that the user add a new skill on the account profile page with a paragraph on Add skill field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show new Skill 
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Management | Expert     | Management  |


	Scenario Outline: TS_201_TC_008 Verify that the user click on cancel button on the skill tab  
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show new Skill 
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Management | Expert     | Management  |  

	#Edit
	Scenario Outline: TS_202_TC_001 Verify that the user edit a skill on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
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
	When I navigate to account profile Skill
	When I check existing Skill
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
	When I navigate to account profile Skill
	When I check existing Skill
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
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I edit a skill with '<SkillEdit>'
	Then The skill should edit successfully
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillEdit | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Communication | Expert     | Teamwork  | Teamwork    |


	#Delete
	Scenario Outline: TS_203_TC_001 Verify that the user delete a skill on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile Skill
	When I check existing Skill
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I delete a skill with '<SkillDelete>'
	Then The skill should delete successfully
	
	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Creativity    | Expert     | Creativity  |
