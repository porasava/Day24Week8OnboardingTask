Feature: 014ccountSettingManageRequest

A short summary of the feature

@tag1
Scenario: 1TS_114_TC_036 Verify the user click on Received requests dropdown and click accept
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	Given I create a listing '<Title>', '<Description>', '<Category>','<Subcategory>','<Tags>','<SkillExchange>' 
	Given I logout from Skill website
	Given I loged into Skill website successfully with '<UserName2>' and '<Password2>'
	When I search for a listing '<Title>' and send request
	When I logout from Skill website
	When I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on Manage request dropdown and select Received requests
	When I click accept
	Then the listing status should change to complete on receive request


	 Examples: 
    | UserName             | Password     | UserName2           | Password2    | Title                     | Description               | Category          | Subcategory            | Tags    | SkillExchange     |
    | Tananya1@hotmail.com | TananyaHappy | Tananya2@hotmail.com | TananyaHappy | Digital Marketing Tananya11 | Digital Marketing Tananya11 | Digital Marketing | Social Media Marketing | Tananya | Digital Marketing |


Scenario: 4TS_114_TC_037 Verify the user click on Received requests dropdown and click decline
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	Given I create a listing '<Title>', '<Description>', '<Category>','<Subcategory>','<Tags>','<SkillExchange>' 
	Given I logout from Skill website
	Given I loged into Skill website successfully with '<UserName2>' and '<Password2>'
	When I search for a listing '<Title>' and send request
	When I logout from Skill website
	When I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on Manage request dropdown and select Received requests
	When I click decline
	Then the listing status should change to declined

	 Examples: 
    | UserName             | Password     | UserName2           | Password2    | Title                   | Description             | Category          | Subcategory | Tags    | SkillExchange     |
    | Tananya1@hotmail.com | TananyaHappy | Tananya2@hotmail.com | TananyaHappy | Graphics Design Tananya1 | Graphics Design Tananya1 | Graphics & Design | Logo Design | Tananya | Graphics & Design |


Scenario: 2TS_114_TC_038 Verify the user click on send request dropdown and click completed button
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on Manage request dropdown and select send Requests
	When I click completed
	Then the listing status should change to review

	 Examples: 
    | UserName             | Password     | Title                      | Description                | Category          | Tags    | SkillExchange     |
    | Tananya2@hotmail.com | TananyaHappy | Digital Marketing Tananya1 | Digital Marketing Tananya1 | Digital Marketing | Tananya | Digital Marketing |


	#Fail it cannot show pop up rate when do automation
#Scenario: 3TS_114_TC_039 Verify the user click on send request dropdown and click review button
#	Given I loged into Skill website successfully with '<UserName2>' and '<Password2>'
#	When I click on Manage request dropdown and select send Requests
#	When I click review
#	Then this listing should show review rate successful
#
#	 Examples: 
#    | UserName             | Password     | Title                      | UserName2            | Password2    |
#    | Tananya1@hotmail.com | TananyaHappy | Digital Marketing Tananya1 | Tananya2@hotmail.com | TananyaHappy |
#


