Feature: Add Skills
		As a Seller
	I want the feature to add my profile details
	So that
	The people seeking for specific skills can look into my details.
	Acceptance Criteria
	Seller is able to add the profile details
@mytag	
Scenario: 01 Test Add Skill Successfully
	Given seller enter skill as "C#"
	And choose skill level as "Beginner"
	When click on Add button
	Then skill should be added to your profile. The alert message,"C# has been added to your skills"should be displayed on the top right corner.
@mytag
Scenario: 02 Test update skill successfully
		Given seller update skill as "Java"
		And update skill level as "Expert"
		When click on update skill button
		Then  skill should be updated.The alert message,"Java has been updated to your skills"should be displayed on the top right corner.
@mytag
Scenario: 03 Test Delete skill successfully
		
		When click on delete skill button as "Java"
		Then skill should be deleted.The alert message,"Java has been deleted"should be displayed on the top right corner.

#Scenario: 04 Test Blank Addskill and blank level successfully
		#Given input for Addskill as ""
		#And input for skill level as ""
		#When click on Addbutton
		#Then skill should be added.The alert message,"Please enter skill and experience level"should be displayed on the top right corner.

#Scenario: 05 Test Blank Addskill and  level successfully
		#Given Input for Addskill as ""
		#And Input for skill level as "intermediate"
		#When click on Addbutton
		#Then skill should be added.The alert message,"Please enter skill and experience level"should be displayed on the top right corner.

#@ignore
#Scenario: 06 Test Blank Addskill and blank level successfully
		#Given inputdata for Addskill as "c"
		#And inputdata for skill level as ""
		#When click on Addbutton
		#Then skill should be added.The alert message,"Please enter skill and experience level"should be displayed on the top right corner.
#@ignore
#Scenario: 07 Test  Addsymbols to skill and  level successfully
		#Given input for Addskill as "[[[[[`````"
		#And input for skill level as "Expert"
		#When click on update
		#Then skill should be added.The alert message,"[[[[[`````has been updated to your skills" should be displayed on the top right corner.
#@ignore
#Scenario: 08 Test  Addsymbols to skill and  level successfully
		#Given input for Addskill as "[[[[[````asdfaf`"
		#And input for skill level as "Expert"
		#When click on update
		#Then skill should be added.The alert message,"[[[[[`````has been updated to your skills" should be displayed on the top right corner.
#@ignore
#Scenario: 09 Test  Addsymbols to skill and  level successfully
		#Given input for Addskill as "[[[[[`````"
		#And input for skill level as "Expert"
		#When click on delete
		#Then skill should be added.The alert message,"[[[[[`````has been deleted to your skills" should be displayed on the top right corner.
#@ignore
#Scenario: 09 Test  duplicate skill and  level successfully
		#Given  Addskill as "C"
		#And  level as "Beginner"
		#When click on Add
		#Then skill should not be added.The alert message,"This skill is already exist in your skill list"should be displayed on the top right corner.
#@ignore
#Scenario: 10 Test  duplicate skill and  change in level successfully
		#Given  Addskill as "C"
		#And  level as "Expert"
		#When click on Add
		#Then skill should not be added.The alert message,"Duplicated data"should be displayed on the top right corner.