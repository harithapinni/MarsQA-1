Feature: Add Profile
		As a Seller
	I want the feature to add my profile details
	So that
	The people seeking for specific profile can look into my details.
	Acceptance Criteria
	Seller is able to add the profile details

#---------------DESCRIPTION-----------------
#   @mytag
#@ignore
#   Scenario: 01 Test Description for seller profile sucessfully
#   Given Seller enter text in description 
#   When  click on save  button
#  Then Description should be added to your profile.The alret message ,"Description has been saved successfully" will be displayed on the top right of the application.
#  @mytag
# Scenario: :02 Test Description Characterlength Sucessfully
#    Given seller try to excedd more than six hundred Characters 
#    Then cursor should be Disable.

# ---------CERTIFICATION-----------
#  @ignore
#Scenario: 01 Test Add Certifications sucessfully           
#				Given  seller enter certification as "ABAP Certification"
#	            And enter certified from  as "SAP"
#	            And select Year as "2014"
#	            When clicks on Add  button
#	            Thencertification should be added to your profile .The alert message, "ISTQB certification has been added to your certification" will be displayed on the top right of the application.	            
#Scenario: 02 Test Update Certifications sucessfully
#	           Given seller updates certification as "AZURE Certification"
#	           And enter certified from  as "Microsoft"
#	           And select Year as "2020"
#	           When clicks on update action button
#	           Then certification should be updated to your profile .The alert message, "ADVANCED ISTQB certification has been updated to your certification" will be displayed on the top right of the application.
#Scenario: 03 Test Delete Certifications sucessfully   
#	          When seller select to delete certification "AZURE Certification"
#             Then certification should be deleted  .The alert message, "AZURE Certification has been deleted from your certification" will be displayed on the top right of the application.	              
#
# @ignore
# Scenario: 04 Test blank cerification unsucessful
#              Given seller enter certification as "ISTQB Certification"  
#              And  remaining fields are blank
#              When clicks on add action button
#              Then  add education should throw an alret message," please enter certification name, certification from and certification year" will be displayed on the top right of the application. 	           
#Scenario: 05 Test Add existing Certifications sucessfully           
#	            Given seller enter certification as "C# certification"
#	            And enter certified from  as "Microsoft"
#	            And  select Year as "2015"
#	            When clicks on Add action button
#	            Then certification should be added to your profile .The alert message, "This information is already exist." will be displayed on the top right of the application.
#Scenario: 06 Test update  existing Certifications sucessfully           
#	            Given seller enter certification as "ISTQB certification"
#	            And enter certified from  as "Microsoft"
#	            And  select Year as "2015"
#	            When clicks on update  action button
#	            Then certification should be added to your profile .The alert message, "This information is already exist." will be displayed on the top right of the application.	          
#  SELLER PROFILE NAME DROPDOWN:
#   ----------------------------------------
#Scenario: 01 Test Title dropdown to edit name
#              Given seller enter FirstName as "haritha"
#              And last name as "Devi"
#              When clicks on save  button
#              Then firstname and lastname should be visible in dropdown.
#Scenario: 02 Test Title dropdown to Update name
#              Given seller enter FirstName as "haritha"
#              And last name as "Upuluri"
#              When clicks on save  button
#             Then updated firstname and lastname should be visible in dropdown.
#Scenario: 03 Test Title dropdown with blank name
#              Given seller enter FirstName as ""
#              And last name as "Upuluri"
#              When clicks on save  button
#             Then  firstname and lastname should not be visible.The message"Firstname and Lastname are required" should be diaplayed
#------- SELLER AVAILABILITY-------
#Scenario: 01 Test Add seller Availability sucessfully
#             Given select Availability as "Part Time"
#             Then Availability should be added to your profile.The alert message,"Availability updated" will be displayed on the top right of the application.
#Scenario: 02 Test Add  Availability sucessfully
#             Given select Availability as "Full Time"
#             Then Availability should be added to your profile.The alert message,"Availability updated" will be displayed on the top right of the application.
#
#----Hours------
#Scenario: 03 Test Add Hours  sucessfully
#            Given select Hours as "More Than 30Hours a Week"
#            Then Hours should be added to your profile.The alert message,"Availability updated" will be displayed on the top right of the application.
#Scenario: 04 Test Add Earn Target sucessfully
#             Given select Earn Target as "Less than $500 per month"
#            Then  Earn Target should be added to your profile.The alert message,"Availability updated" will be displayed on the top right of the application.
#	
