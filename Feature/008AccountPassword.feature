Feature: AccountPassword

Validate that the user able to change password


	Scenario Outline: TS_107_TC_020 Verify that user change password with correct password
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to password pop up 
	When I change password with '<CurrentPassword>', '<NewPassword>', '<ConfirmPassword>'
	Then It should show pop up Password Changed Successfully
	Then I change password back with '<CurrentPassword2>', '<NewPassword2>', '<ConfirmPassword2>'


	 Examples: 
    | UserName             | Password     | CurrentPassword | NewPassword   | ConfirmPassword | CurrentPassword2 | NewPassword2 | ConfirmPassword2 |
    | Tananya1@hotmail.com | TananyaHappy | TananyaHappy    | TananyaHappy1 | TananyaHappy1   | TananyaHappy1   | TananyaHappy | TananyaHappy     |



	Scenario Outline: TS_107_TC_021 Verify that user change password with invalid current password
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to password pop up 
	When I change password with '<CurrentPassword>', '<NewPassword>', '<ConfirmPassword>'
	Then It should show pop up Password Verification Failed

	 Examples: 
    | UserName             | Password     | CurrentPassword | NewPassword   | ConfirmPassword |
    | Tananya1@hotmail.com | TananyaHappy | TananyaHappy4   | TananyaHappy1 | TananyaHappy1   |



	Scenario Outline: TS_107_TC_022 Verify that user change password with blank current password
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to password pop up 
	When I change password with '<CurrentPassword>', '<NewPassword>', '<ConfirmPassword>'
	Then It should show pop up Error while Updating Password details

	 Examples: 
    | UserName             | Password     | CurrentPassword | NewPassword   | ConfirmPassword |
    | Tananya1@hotmail.com | TananyaHappy |                 | TananyaHappy1 | TananyaHappy1   |


	Scenario Outline: TS_107_TC_023 Verify that user change password with all blank 
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to password pop up 
	When I change password with '<CurrentPassword>', '<NewPassword>', '<ConfirmPassword>'
	Then It should show pop up Error Please fill all the details before Submit

	 Examples: 
    | UserName             | Password     | CurrentPassword | NewPassword | ConfirmPassword |
    | Tananya1@hotmail.com | TananyaHappy |                 |             |                 |


	Scenario Outline: TS_107_TC_024 Verify that user change password with invalid new password format
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to password pop up 
	When I change password with '<CurrentPassword>', '<NewPassword>', '<ConfirmPassword>'
	Then It should show pop up Error Passwords required at least 6 characters

	 Examples: 
    | UserName             | Password     | CurrentPassword | NewPassword | ConfirmPassword |
    | Tananya1@hotmail.com | TananyaHappy | TananyaHappy    | 8888        | 8888            |


	Scenario Outline: TS_107_TC_025 Verify that the user changes the password without matching the confirm password
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to password pop up 
	When I change password with '<CurrentPassword>', '<NewPassword>', '<ConfirmPassword>'
	Then It should show pop up Error Passwords does not match

	 Examples: 
    | UserName             | Password     | CurrentPassword | NewPassword   | ConfirmPassword |
    | Tananya1@hotmail.com | TananyaHappy | TananyaHappy    | TananyaHappy1 | TananyaHappy2   |



