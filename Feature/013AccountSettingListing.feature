Feature: 013AccountSettingListing

A short summary of the feature

	
	Scenario: 1TS_113_TC_031 Verify the user click edit listing link on manage listings page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	Given I create a listing '<Title>', '<Description>', '<Category>','<SubCategory>','<Tags>','<SkillExchange>' 
	When I navigate to Manage listing page
	When I edit listing '<TitleEdit>', '<DescriptionEdit>', '<CategoryEdit>','<SubCategoryEdit>','<TagsEdit>','<SkillExchangeEdit>' 
	Then It should show the listing update on the listing detail page '<Title>', '<Description>'

	 Examples: 
    | UserName            | Password     | Title                   | Description             | Category          | SubCategory | Tags    | SkillExchange     | TitleEdit                | DescriptionEdit          | CategoryEdit      | SubCategoryEdit | TagsEdit | SkillExchangeEdit |
    | Tananya@hotmail.com | TananyaHappy | Graphics Design Tananya | Graphics Design Tananya | Graphics & Design | Logo Design | Tananya | Graphics & Design | Graphics Design Tananya1 | Graphics Design Tananya1 | Graphics & Design | Logo Design     | Tananya  | Graphics & Design |

	
	Scenario: 2TS_113_TC_032 Verify the user click on see listing link on manage listings page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to Manage listing page
	When I click on see listing
	Then It should show the listing on the listing detail page '<Title>', '<Description>', '<Category>','<SubCategory>','<SkillExchange>','<LocationType>'

	 Examples: 
    | UserName            | Password     | Title                    | Description              | Category          | SubCategory | SkillExchange     | LocationType |
    | Tananya@hotmail.com | TananyaHappy | Graphics Design Tananya1 | Graphics Design Tananya1 | Graphics & Design | Logo Design | Graphics & Design | Online       |

	
	Scenario: 3TS_113_TC_035 Verify the user click on Deactivate listing link on manage listings page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to Manage listing page
	When I click on Deactivate listing 
	Then It should show Service has been deactivated

	Examples: 
    | UserName            | Password     | Title                    |
    | Tananya@hotmail.com | TananyaHappy | Graphics Design Tananya1 |

	
	Scenario: 4TS_113_TC_034 Verify the user click on activate listing link on manage listings page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to Manage listing page
	When I click on activate listing 
	Then It should show Service has been activated

	Examples: 
    | UserName            | Password     | Title                    |
    | Tananya@hotmail.com | TananyaHappy | Graphics Design Tananya1 |

	
	Scenario: 5TS_113_TC_033 Verify the user click on delete listing link on manage listings page
	Given I loged into Skill website successfully with '<UserName>' and '<Password>'
	When I navigate to Manage listing page
	When I click on delete listing '<Title>'
	Then The listing should be delete successfully

	 Examples: 
    | UserName            | Password     | Title                    |
    | Tananya@hotmail.com | TananyaHappy | Graphics Design Tananya1 |