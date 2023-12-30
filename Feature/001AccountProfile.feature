Feature: AccountProfile

Validate that the user able to edit Account profile


Scenario Outline: TS_100_TC_001 Verify that the user edit First name on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I edit firstname with '<FirstName>'
	Then It should show new Firstname 
	Then I Edit back to the original firstname '<OriginalFirstName>'

	 Examples: 
    | UserName            | Password     | FirstName   | OriginalFirstName |
    | Tananya@hotmail.com | TananyaHappy | TananyaEdit | Tananya           |


	Scenario Outline: TS_101_TC_002 Verify that the user edit Last name on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I edit Lastname with '<LastNameEdit>'
	Then It shoulsd show new Lastname 
	Then I Edit back to the original Lastname '<OriginalLastName>'

	 Examples: 
    | UserName            | Password     | LastNameEdit   | OriginalLastName |
    | Tananya@hotmail.com | TananyaHappy | HappyEdit | Happy           |
	

	Scenario Outline: TS_102_TC_003 Verify that the user edit description on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I edit Description with '<Description>'
	Then Description should be edit successfully
	Then I Edit back to the original Description '<OriginalDescription>'

	 Examples: 
    | UserName            | Password     | Description       | OriginalDescription |
    | Tananya@hotmail.com | TananyaHappy | Hello Description |   Original             |


	Scenario Outline: TS_103_TC_004 Verify that the user add a new Languages on the account profile page with correct mandatory
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then Language should be add successfully
	Then Remove Language
	Then Language should be remove successful

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel |
    | Tananya@hotmail.com | TananyaHappy | Spanish  | Basic        |



	Scenario Outline: TS_103_TC_005 Verify that the user add a new Languages on the account profile page with incorrect mandatory
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	Then It should show error Please enter language and level


	 Examples: 
    | UserName            | Password     | Language | LanguageLevel |
    | Tananya@hotmail.com | TananyaHappy | Arabic   |               |


	Scenario Outline: TS_103_TC_006 Verify that the user edit a Languages on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	When I edit a Language with '<LanguageEdit>'
	Then Language should be Edited successfully , '<LanguageEdit>'
	Then Remove Language
	Then Language should be remove successfully

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel | LanguageEdit |
    | Tananya@hotmail.com | TananyaHappy | German   | Basic         | Korean       | 



	Scenario Outline: TS_103_TC_007 Verify that the user delete a Languages on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add new Language with '<Language>', and '<LanguageLevel>'
	When I delete a Language '<LanguageDelete>'
	Then Language should be remove successfully

	 Examples: 
    | UserName            | Password     | Language | LanguageLevel | LanguageDelete |
    | Tananya@hotmail.com | TananyaHappy | French  | Fluent        | French     |


	Scenario Outline: TS_104_TC_008 Verify that the user add a skill on the account profile page  with correct mandatory
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show new Skill 
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Management | Expert        | Management     |


	Scenario Outline: TS_104_TC_009 Verify that the user add a skill on the account profile page  with incorrect mandatory
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	Then It shoulsd show error Please enter skill and experience level

	 Examples: 
    | UserName            | Password     | Skill      | SkillLevel |
    | Tananya@hotmail.com | TananyaHappy | Leadership |            |


	Scenario Outline: TS_104_TC_010 Verify that the user edit a skill on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I edit a skill with '<SkillEdit>'
	Then The skill should edit successfully
	Then I delete a Skill '<SkillDelete>'
	Then Skill should be remove successfully

	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillEdit | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Communication | Expert     | Teamwork  | Teamwork    |


	Scenario Outline: TS_104_TC_011 Verify that the user delete a skill on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Skill with '<Skill>', and '<SkillLevel>'
	When I delete a skill with '<SkillDelete>'
	Then The skill should delete successfully
	
	 Examples: 
    | UserName            | Password     | Skill         | SkillLevel | SkillDelete |
    | Tananya@hotmail.com | TananyaHappy | Creativity    | Expert     | Creativity  |


	Scenario Outline: TS_105_TC_012 Verify that the user add an Education on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Education with '<UniversityName>', '<Country>', '<Title>', '<Degree>', and '<YearOfGraduate>'
	Then Education should be add successfully
	Then I delete a Education with '<UniversityName>'
	Then The Education should delete successfully
	
	 Examples: 
    | UserName            | Password     | UniversityName | Country   | Title  | Degree | YearOfGraduate |
    | Tananya@hotmail.com | TananyaHappy | Hogwarts       | Neverland | M.Tech |  Master| 2023           |  


	Scenario Outline: TS_105_TC_013 Verify that the user add an Education on the account profile page with blank format
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Education with '<UniversityName>', '<Country>', '<Title>', '<Degree>', and '<YearOfGraduate>'
	Then It should show error  Please enter all the fields
	
	 Examples: 
    | UserName            | Password     | UniversityName                    | Country | Title | Degree | YearOfGraduate |
    | Tananya@hotmail.com | TananyaHappy | Auckland University of Technology |         |       |        |                |


	Scenario Outline: TS_105_TC_014 Verify that the user edit an Education on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Education with '<UniversityName>', '<Country>', '<Title>', '<Degree>', and '<YearOfGraduate>'
	When I edit Education with '<UniversityNameEdit>', '<CountryEdit>', '<TitleEdit>', '<DegreeEdit>', and '<YearOfGraduateEdit>'
	Then I delete a Education with '<UniversityNameDelete>'
	Then The Education should delete successfully
	
	 Examples: 
    | UserName            | Password     | UniversityName | Country   | Title  | Degree | YearOfGraduate | UniversityNameEdit | CountryEdit | TitleEdit | DegreeEdit | YearOfGraduateEdit | UniversityNameDelete |
    | Tananya@hotmail.com | TananyaHappy | Hogwarts       | Neverland | M.Tech | Master | 2023           | Lincoln            | Neverland   | M.Tech    | Master     | 2023               | Lincoln              |


	Scenario Outline: TS_105_TC_015 Verify that the user delete an Education on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Education with '<UniversityName>', '<Country>', '<Title>', '<Degree>', and '<YearOfGraduate>'
	When I delete Education with '<UniversityNameDelete>'
	Then The Education should delete successfully
	
	 Examples: 
    | UserName            | Password     | UniversityName | Country   | Title  | Degree | YearOfGraduate | UniversityNameDelete |
    | Tananya@hotmail.com | TananyaHappy | Massey       | Neverland | M.Tech | Master | 2023           |Massey               |



	Scenario Outline: TS_106_TC_016 Verify that the user add an Certification on the account profile page with correct mandatory field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Certification with '<CertificateOrAward>', '<From>', and '<Year>'
	Then Certification should be add successfully
	Then I delete Certification with '<CertificateDelete>'
	Then The Certification should delete successfully
	
	 Examples: 
    | UserName            | Password     | CertificateOrAward | From | Year | CertificateDelete |
    | Tananya@hotmail.com | TananyaHappy | Computering        | NZQA | 2023 | Computering        |


	Scenario Outline: TS_106_TC_017 Verify that the user add an Certification on the account profile page with incorrect mandatory field
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Certification with '<CertificateOrAward>', '<From>', and '<Year>'
	Then It should show error Please enter Certification Name, Certification From and Certification Year

	
	 Examples: 
    | UserName            | Password     | CertificateOrAward | From | Year |
    | Tananya@hotmail.com | TananyaHappy | Computering        |      |      |


	Scenario Outline: TS_106_TC_018 Verify that the user edit an Certification on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Certification with '<CertificateOrAward>', '<From>', and '<Year>'
	When I edit a Certification with '<CertificateOrAwardEdit>', '<FromEdit>', and '<YearEdit>'
	Then Certification should be edit successfully
	Then I delete Certification with '<CertificateDelete>'
	Then The Certification should delete successfully
	
	 Examples: 
    | UserName            | Password     | CertificateOrAward | From | Year | CertificateOrAwardEdit | FromEdit | YearEdit | CertificateDelete |
    | Tananya@hotmail.com | TananyaHappy | Computering        | NZQA | 2023 | Gardening              | NZQA     | 2023     | Gardening         |

	Scenario Outline: TS_106_TC_019 Verify that the user delete an Certification on the account profile page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to account profile 
	When I add a new Certification with '<CertificateOrAward>', '<From>', and '<Year>'
	When I delete Certification with '<CertificateDelete>'
	Then The Certification should delete successfully
	
	 Examples: 
    | UserName            | Password     | CertificateOrAward | From | Year | CertificateDelete |
    | Tananya@hotmail.com | TananyaHappy | Business           | NZQA | 2023 | Business          |


