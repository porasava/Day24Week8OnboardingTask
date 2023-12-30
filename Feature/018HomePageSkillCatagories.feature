Feature: 018HomePageSkillCatagories

A short summary of the feature

@tag1
Scenario: TS_119_TC_064 Verify the 'Explore Categories' link for  Graphic Design on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on '<Skill>' link
	Then It should display all skill on the result page

	 Examples: 
    | UserName            | Password     | Skill          | SkillResult       |
    | Tananya@hotmail.com | TananyaHappy | GraphicsDesign | Graphics & Design |


Scenario: TS_119_TC_065 Verify the 'Explore Categories' link for Digital Marketing on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on '<Skill>' link
	Then It should display all skill on the result page

	 Examples: 
    | UserName            | Password     | Skill            | SkillResult       |
    | Tananya@hotmail.com | TananyaHappy | DigitalMarketing | Digital Marketing |


	Scenario: TS_119_TC_066 Verify the 'Explore Categories' link for Writing & Translation on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on '<Skill>' link
	Then It should display all skill on the result page

	 Examples: 
    | UserName            | Password     | Skill              | SkillResult           |
    | Tananya@hotmail.com | TananyaHappy | WritingTranslation | Writing & Translation |


	Scenario: TS_119_TC_067 Verify the 'Explore Categories' link for Video Animation on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on '<Skill>' link
	Then It should display all skill on the result page

	 Examples: 
    | UserName            | Password     | Skill          | SkillResult       |
    | Tananya@hotmail.com | TananyaHappy | VideoAnimation | Video & Animation |


	Scenario: TS_119_TC_068 Verify the 'Explore Categories' link for Music Audio on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on '<Skill>' link
	Then It should display all skill on the result page

	 Examples: 
    | UserName            | Password     | Skill      | SkillResult   |
    | Tananya@hotmail.com | TananyaHappy | MusicAudio | Music & Audio |

	Scenario: TS_119_TC_069 Verify the 'Explore Categories' link for Programming Tech on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on '<Skill>' link
	Then It should display all skill on the result page

	 Examples: 
    | UserName            | Password     | Skill           | SkillResult        |
    | Tananya@hotmail.com | TananyaHappy | ProgrammingTech | Programming & Tech |


	Scenario: TS_119_TC_070 Verify the 'Explore Categories' link for Business on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on '<Skill>' link
	Then It should display all skill on the result page

	 Examples: 
    | UserName            | Password     | Skill    | SkillResult |
    | Tananya@hotmail.com | TananyaHappy | Business | Business    |

	Scenario: TS_119_TC_071 Verify the 'Explore Categories' link for Fun Lifestyle on the home page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I click on '<Skill>' link
	Then It should display all skill on the result page

	 Examples: 
    | UserName            | Password     | Skill        | SkillResult     |
    | Tananya@hotmail.com | TananyaHappy | FunLifestyle | Fun & Lifestyle |
