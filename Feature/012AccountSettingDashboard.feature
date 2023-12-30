Feature: 012AccountSettingDashboard

A short summary of the feature

@tag1
Scenario: TS_112_TC_030 Verify the user click on Dashboard link
	Given  I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account settings
	When I click on Dashboard
	Then It should show notification page


	 Examples: 
    | UserName             | Password     |
    | Tananya1@hotmail.com | TananyaHappy | 