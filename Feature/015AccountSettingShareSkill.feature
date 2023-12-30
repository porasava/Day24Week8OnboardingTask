Feature: 015AccountSettingShareSkill

A short summary of the feature

@tag1
Scenario: TS_115_TC_040 Verify the user share new skill and put blank on Title text box
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I create a listing '<Title>', '<Description>', '<Category>','<Subcategory>','<Tags>','<SkillExchange>' 
	Then It should show error Title is required

	 Examples: 
    | UserName             | Password     | Title | Description             | Category          | Subcategory | Tags    | SkillExchange     |
    | Tananya1@hotmail.com | TananyaHappy |       | Graphics Design Tananya | Graphics & Design | Logo Design | Tananya | Graphics & Design |



	Scenario: TS_115_TC_041 Verify the user share new skill and put blank on Description text box
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I create a listing '<Title>', '<Description>', '<Category>','<Subcategory>','<Tags>','<SkillExchange>' 
	Then It should show error Description is required

	 Examples: 
    | UserName             | Password     | Title                   | Description | Category          | Subcategory | Tags    | SkillExchange     |
    | Tananya1@hotmail.com | TananyaHappy | Graphics Design Tananya |             | Graphics & Design | Logo Design | Tananya | Graphics & Design |
	


	Scenario: TS_115_TC_042 Verify the user share new skill and put blank on Category text box
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I create a listing '<Title>', '<Description>', '<Category>','<Subcategory>','<Tags>','<SkillExchange>' 
	Then It should show error Category is required

	 Examples: 
    | UserName             | Password     | Title                   | Description             | Category | Subcategory | Tags    | SkillExchange     |
    | Tananya1@hotmail.com | TananyaHappy | Graphics Design Tananya | Graphics Design Tananya |          |             | Tananya | Graphics & Design |



	Scenario: TS_115_TC_043 Verify the user share new skill and put blank on Tags text box
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I create a listing '<Title>', '<Description>', '<Category>','<Subcategory>','<Tags>','<SkillExchange>' 
	Then It should show error Tags are required

	 Examples: 
    | UserName             | Password     | Title                   | Description             | Category          | Subcategory | Tags | SkillExchange     |
    | Tananya1@hotmail.com | TananyaHappy | Graphics Design Tananya | Graphics Design Tananya | Graphics & Design | Logo Design |      | Graphics & Design |


	Scenario: TS_115_TC_044 Verify the user share new skill and put blank on Skill-Exchange text box
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I create a listing '<Title>', '<Description>', '<Category>','<Subcategory>','<Tags>','<SkillExchange>' 
	Then It should show error Skill-Exchange are required

	 Examples: 
    | UserName             | Password     | Title                   | Description             | Category          | Subcategory | Tags    | SkillExchange |
    | Tananya1@hotmail.com | TananyaHappy | Graphics Design Tananya | Graphics Design Tananya | Graphics & Design | Logo Design | Tananya |               |


