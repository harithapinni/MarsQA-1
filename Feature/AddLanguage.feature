Feature: Add Language
		As a Seller
	I want the feature to add my profile details
	So that
	The people seeking for specific language can look into my details.
	Acceptance Criteria
	Seller is able to add the profile details
@mytag
Scenario: 01 Test Add Language Successfully
	Given seller enter language as "English"
	And choose language level as "Fluent"
	When click on Add action button
	Then  language should be added to your profile. The alert message,"English has been added to your languages"should be displayed on the top right corner.
@mytag
Scenario: 02 Test Update Language Successfully
	Given seller update language as "Russian"
	And update language level as "Basic"
	When click on Update button
	Then  language should be updated. The alert message,"Russian has been updated to your languages"should be displayed on the top right corner.
@mytag
Scenario: 03 Test Delete Language Successfully
	When seller choose to delete a language "Russian"
	Then  language should be deleted. The alert message,"Russian has been deleted from your languages"should be displayed on the top right corner.
#@ignore
#Scenario: 04 Test  Empty Language and Empty  level Successfully
#	Given seller Enter language as ""
#	And choose Language level as ""
#	When Click on Add action button
#	Then  Record should not be added. The alert message,"Please enter Language and Language Level"should be displayed on the top right corner.
#@ignore
#	Scenario: 05 Test Add Empty Language and choose language level Successfully
#	Given Seller enter language as ""
#	And Choose language level as "Basic"
#	When click on Add  button
#	Then  language and level should not be added. The alert message,"Please enter Language and Level"should be displayed on the top right corner.
#@ignore @web	
#	Scenario: 06 Test  Valid Language and Blank language level Successfully
#	Given Seller enter language as "Tamil"
#	And Select language level as ""
#	When Click on Add action button
#	Then  language and level should not be added. The alert message,"Please enter Language and Level"should be displayed on the top right corner.
#@ignore @web	
#Scenario:07 Test Add duplicate Language  Successfully
#	Given Seller enter language as "Marathi"
#	And Choose language level as "Basic"
#	When click on Add  button
#	Then language should  not be added to your profile. The alert message,"This language is already exist in your Language list"should be displayed on the top right corner.
#@ignore @web
#Scenario:08 Test Add duplicate Language and select level Successfully
#	Given Seller enter language as "Marathi"
#	And choose  level as "Conversational"
#	When Click on Add action button
#	Then language should  not be added to your profile. The alert message,"Duplicated data"should be displayed on the top right corner.
#@ignore @web
#Scenario:09 Test Add numbers to the Language And select level Successfully 
#	Given Seller enter language as "123"
#	And Select  language level as "Fluent"
#	When clicked on Add action button
#	Then language should be added to your profile.The alert message,"123 has been added to your languages"should be displayed.
#@ignore @web
#Scenario:10 Test Add numbers and symbols to the Language and level 
#	Given Seller enter language as "@&*(12ghg"
#	And Select language level as "Conversational"
#	When hit on Add action button
#	Then language  should be added to your profile.The alert message,"@&*(12ghg has been added to your language"should be displayed
#Scenario:10 Test Update numberand symbol to the Language and change level Successfully
#	Given Seller enter language as "@&*(12ghg"
#	And Select language level as "Basic"
#	When hit on Add action button
#	Then language  should be added to your profile.The alert message,"@&*(12ghg has been added to your language"should be displayed
#Scenario:11 Test Update  Language and  level Successfully
#	Given Seller enter language as "@&*(12ghg"
#	And Select language level as "Basic"
#	When hit on Add action button
#	Then language  should be added to your profile.The alert message,"This language is already added to your language list"should be displayed
#Scenario:12 Test Update blank Language and  level Successfully
#	Given Seller enter language as ""
#	And Select language level as "Basic"
#	When hit on Add action button
#	Then language  should be added to your profile.The alert message,"please enter language and level"should be displayed
#Scenario:13 Test Update blank Language and  blank level Successfully
#	Given Seller enter language as ""
#	And Select language level as ""
#	When hit on Add action button
#	Then language  should be added to your profile.The alert message,"please enter language and level"should be displayed
#  Scenario: 14 Test Seller is adding more than four languages 
#		Given Seller wants to add more than 4 languages 
#      Then Add New action button should be  dissapeared as user cannot add more than four languages

