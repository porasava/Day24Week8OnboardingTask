Feature: 019HomePageChat

A short summary of the feature

@tag1
Scenario: TS_120_TC_072 Verify the 'Chat' link on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I try to chat with person '<title>','<chat>'
	When I logout from Skill website
	When I loged into Skill website successfully with '<UserName2>' and '<Password2>'
	When I ckick on chat 
	Then User should see chat notification from person

	 Examples: 
    | UserName             | Password     | chat             | UserName2            | Password2    | title    |
    | Tananya2@hotmail.com | TananyaHappy | Hi I am Tananya2 | Tananya1@hotmail.com | TananyaHappy | Tananya1 |
