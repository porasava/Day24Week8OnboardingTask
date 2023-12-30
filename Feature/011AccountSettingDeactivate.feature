Feature: 011AccountSettingDeactivate

A short summary of the feature

@tag1
Scenario: TS_111_TC_029 Verify deactivate button on account Setting page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account settings
	When I selected deactivate
	Then It should show Deactivated account


	 Examples: 
    | UserName             | Password     |
    | TananyaDe@hotmail.com | TananyaHappy | 