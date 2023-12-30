Feature: 009AccountRegister

A short summary of the feature

#i am not sure how to reuse old emil address so, I did not do the register successful case
#	Scenario: TS_116_TC_045 Verify that the user create a new account with correct mandatory field
#	Given I navigate into Skill website successfully
#	When I create a new account  '<FirstName>','<LastName>','<Email>','<Password>','<ConfirmPassword>'
#	Then User should show message Registration successful
#
#	 Examples: 
#    | Firstname    | LastName   | Email                    | Password     | ConfirmPassword | 
#    | TananyaRegis | HappyRegis | TananyaRegis@hotmail.com | TananyaHappy | TananyaHappy    | 


	Scenario: TS_116_TC_046 Verify that the user creates a new account and enters a number in the 'First Name' field.
	Given I navigate into Skill website successfully
	When I create a new account '<FirstName>','<LastName>','<Email>','<Password>','<ConfirmPassword>', '<agree>'
	Then It should show error message Names must contain at least one letter

	 Examples: 
    | FirstName | LastName   | Email                    | Password     | ConfirmPassword | agree |
    | 88888888  | HappyRegis | TananyaRegis@hotmail.com | TananyaHappy | TananyaHappy    | check |


	Scenario: TS_116_TC_047 Verify that the user creates a new account and enters a number in the 'Last Name' field.
	Given I navigate into Skill website successfully
	When I create a new account '<FirstName>','<LastName>','<Email>','<Password>','<ConfirmPassword>', '<agree>'
	Then It should show error message Lastnames must contain at least one letter

	 Examples: 
    | FirstName     | LastName | Email                    | Password     | ConfirmPassword | agree |
    | TananyaRegis | 88888888 | TananyaRegis@hotmail.com | TananyaHappy | TananyaHappy    |check |


	Scenario: TS_116_TC_048 Verify that the user creates a new account with an incorrect format in the 'Email Address' field.
	Given I navigate into Skill website successfully
	When I create a new account '<FirstName>','<LastName>','<Email>','<Password>','<ConfirmPassword>', '<agree>'
	Then It should show error message Please enter a valid email address.

	 Examples: 
    | FirstName     | LastName   | Email        | Password     | ConfirmPassword | agree |
    | TananyaRegis | HappyRegis | TananyaRegis | TananyaHappy | TananyaHappy    |check |


	Scenario: TS_116_TC_049 Verify that the user create a new account with Password less than 6 characters
	Given I navigate into Skill website successfully
	When I create a new account '<FirstName>','<LastName>','<Email>','<Password>','<ConfirmPassword>', '<agree>'
	Then It should show error message Password must be at least 6 letters 

	 Examples: 
    | FirstName    | LastName   | Email                    | Password | ConfirmPassword | agree |
    | TananyaRegis | HappyRegis | TananyaRegis@hotmail.com | Tan      | Tan             | check |


	Scenario: TS_116_TC_050 Verify that the user create a new account with wrong Confirm Password field
	Given I navigate into Skill website successfully
	When I create a new account '<FirstName>','<LastName>','<Email>','<Password>','<ConfirmPassword>', '<agree>'
	Then It should show error message Does not match password. 

	 Examples: 
    | FirstName    | LastName   | Email                    | Password     | ConfirmPassword | agree |
    | TananyaRegis | HappyRegis | TananyaRegis@hotmail.com | TananyaHappy | Tananya         | check |


	Scenario: TS_116_TC_051 Verify that the user create a new account with uncheck agree terms and conditions
	Given I navigate into Skill website successfully
	When I create a new account '<FirstName>','<LastName>','<Email>','<Password>','<ConfirmPassword>', '<agree>'
	Then It should show error message You must agree to the terms and conditions.

	 Examples: 
    | FirstName     | LastName   | Email                    | Password     | ConfirmPassword |  agree |
    | TananyaRegis | HappyRegis | TananyaRegis@hotmail.com | TananyaHappy | TananyaHappy    | uncheck |


	Scenario: TS_116_TC_052 Verify that the user login from the sign up pop up
	Given I navigate into Skill website successfully
	When I loged into Skill website successfully with '<UserName>' and '<Password>'
	Then user should sign in successfully

	 Examples: 
    | UserName            | Password     |
    | Tananya@hotmail.com | TananyaHappy |

