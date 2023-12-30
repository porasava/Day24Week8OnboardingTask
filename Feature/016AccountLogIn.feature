Feature: 016AccountSignIn

Validate that the user able to sign in


Scenario Outline: TS_117_TC_053 Verify that the user login with valid username and password from the login button
	Given I navigate to Skills website
	When I put '<UserName>' and '<Password>'
	Then I loged into Skill website successfully and go to Account Profile page

	 Examples: 
    | UserName  | Password         |
    | Tananya@hotmail.com | TananyaHappy | 


Scenario: TS_117_TC_054 Verify that the user login with invalid Email format
	Given I navigate to Skills website
	When I put '<UserName>' and '<Password>'
	Then It should show error Please enter valid email address

		 Examples: 
    | UserName  | Password         |
    | 999 | TananyaHappy | 

	 
Scenario: TS_117_TC_055 Verify that the user login with wrong Email
	Given I navigate to Skills website
	When I put '<UserName>' and '<Password>'
	Then It should show Error Confirm Your Email

		 Examples: 
    | UserName  | Password         |
    | gg@hotmail.com | TananyaHappy | 


	#Web defect. It did not show error wrong email or password
#Scenario Outline: TS_117_TC_056 Verify that the user login with wrong password
#	Given I navigate to Skills website
#	When I put '<UserName>' and '<Password>'
#	Then It should show error wrong email or password
#
#	 Examples: 
#    | UserName  | Password         |
#    | Tananya@hotmail.com | Tananya| 


Scenario Outline:TS_117_TC_057 Verify that the user login with password less than 6 characters
	Given I navigate to Skills website
	When I put '<UserName>' and '<Password>'
	Then  It should show error Password must be at least 6 characters

	 Examples: 
    | UserName  | Password         |
    | Tananya@hotmail.com | ttttt | 


	#remember me are not working. it is not remember password after click
#Scenario Outline:TS_117_TC_058 Verify that the user click on remember me from the login button
#	Given I navigate to Skills website
#	When I put '<UserName>' and '<Password>'
#	When I clicked remember me
#	When I loged into Skill website successfully
#	When I logout from the website
#	When I input '<UserName>'
#	Then The password should auto genarate
#
#	 Examples: 
#    | UserName  | Password         |
#    | Tananya@hotmail.com | TananyaHappy | 


Scenario Outline:TS_117_TC_059 Verify that the user click on forgot password link from the login pop up
	Given I navigate to Skills website
	When I Click forgot password
	When I input '<UserName>'
	When I click send varification email
	Then It should show Please check your email to reset password and A recovery link has been sent to your inbox.

	 Examples: 
    | UserName  |
    | Tananya@hotmail.com |  


Scenario Outline:TS_117_TC_060 Verify that the user click on forgot password link from the login pop up and did not fill email
	Given I navigate to Skills website
	When I Click forgot password
	When I click send varification email
	Then It should show error field cannot be empty

	# no TC61


Scenario Outline:TS_117_TC_062 Verify that the user click on Join link from the log in pop up
	Given I navigate to Skills website
	When I click on Join link
	Then It should directly go to the registration pop-up

