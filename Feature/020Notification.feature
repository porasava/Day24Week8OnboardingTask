Feature: 020Notification

A short summary of the feature

@tag1
Scenario: TS_121_TC_073 Verify 'mark all read' link on notification message
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When User click on Notification on the top right of the page
	When User click mark all read link


	 Examples: 
    | UserName             | Password     | UserName2            | Password2    | Chat          | title    |
    | Tananya1@hotmail.com | TananyaHappy | Tananya2@hotmail.com | TananyaHappy | Hello Tananya | Tananya2 |


	Scenario: TS_121_TC_074 Verify 'see all' link on notification message
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When User click on Notification on the top right of the page
	When User click see all link
	Then It should show notification page

	 Examples: 
    | UserName            | Password     |
    | Tananya@hotmail.com | TananyaHappy | 


	Scenario: TS_121_TC_075 Verify 'select all' button on notification message page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When User click on Notification on the top right of the page
	When User click select all link
	Then all message should be checked

	 Examples: 
    | UserName            | Password     |
    | Tananya@hotmail.com | TananyaHappy | 


	Scenario: TS_121_TC_076 Verify 'unselect all' button on notification message page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When User click on Notification on the top right of the page
	When User click select all link
	Then All messages should be unchecked

	 Examples: 
    | UserName            | Password     |
    | Tananya@hotmail.com | TananyaHappy | 


	Scenario: TS_121_TC_077 Verify delete a message on notification page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When User click on Notification on the top right of the page
	When User click delete a message
	Then It should delete one notification from the notification page

	 Examples: 
    | UserName            | Password     |
    | Tananya@hotmail.com | TananyaHappy | 

	Scenario: TS_121_TC_078 Verify 'select one' link on notification message
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When User click on Notification on the top right of the page
	When User select a message
	Then It should show Received Requests page

	 Examples: 
    | UserName            | Password     |
    | Tananya@hotmail.com | TananyaHappy | 



