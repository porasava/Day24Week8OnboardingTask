Feature: 010AccountSettingPassword

A short summary of the feature

@tag1
Scenario: TS_110_TC_028 Verify change Password on account Setting page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account settings 
	When Edit password in the account setting page with '<CurrentPassword>', '<NewPassword>', '<ConfirmPassword>'
	Then It should show pop up Password Changed Successfully
	Then I change password back with '<CurrentPassword2>', '<NewPassword2>', '<ConfirmPassword2>' in the account setting page


	 Examples: 
    | UserName             | Password     | CurrentPassword | NewPassword   | ConfirmPassword | CurrentPassword2 | NewPassword2 | ConfirmPassword2 |
    | Tananya1@hotmail.com | TananyaHappy | TananyaHappy    | TananyaHappy1 | TananyaHappy1   | TananyaHappy1    | TananyaHappy | TananyaHappy     |