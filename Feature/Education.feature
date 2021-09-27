Feature: Add Education
		As a Seller
	I want the feature to add my profile details
	So that
	The people seeking for education can look into my details.
	Acceptance Criteria
	Seller is able to add the profile details
@mytag
Scenario: 01 Test Add Education Successfully
	Given seller enter university as "Auckland University"
	And choose country  as "New Zealand"
	And title as "B.Tech"
	And degree as 4
	And choose year as 2020
	When click on Add button in Education
	Then Education should be added to Education tab. The alert message,"Education has been added"should be displayed on the top right corner.
@mytag
Scenario: 02 Test Update Education Successfully
	Given seller Update university as "JNTU"
	And select country  as "Nepal"
	And choose title as "M.Tech"
	And years degree as 2
	And select year as 2012
	When click  Update button  
	Then Education should be updated.The alert message,"Education as been updated"should be displayed on the top right corner.
@mytag
Scenario: 03 Test Delete Education Successfully
	When click  delete button as"JNTU"
	Then Education should be deleted.The alert message,"Education entry successfully removed"should be displayed on the top right corner.
#ignore
#Scenario:04Test Add blank Education Successfully
#Given seller Add university as ""
	#And select country  as ""
	#And choose title as ""
	#And years degree as ""
	#And select year as ""
	#When click  Add button  
	#Then Education should be not be added.The alert message,"Please enter all fields"should be displayed.
##Scenario:05Test Add blank university in  Education 
#Given seller Add university as ""
	#And select country  as ""
	#And choose title as "B.A"
	#And years degree as "5"
	#And select year as "2007"
	#When click  Add button  
	#Then Education should be not be added.The alert message,"Please enter all fields"should be displayed.
##Scenario:06Test Add blank country and fill all the other fields in  Education Successfully 
#Given seller Add university as "Andhra University"
	#And select country  as ""
	#And choose title as "B.A"
	#And years degree as "5"
	#And select year as "2007"
	#When click  Add button  
	#Then Education should be not be added.The alert message,"Please enter all fields"should be displayed.
##Scenario:07 Test Update duplicate  Education Successfully 
#Given seller Update university as "Andhra University"
	#And select country  as "India"
	#And choose title as "B.Sc"
	#And years degree as "5345"
	#And select year as "2007"
	#When click update button  
	#Then Education should be not be added.The alert message,"This information is already exist"should be displayed.
##Scenario:08 Test Add blank country and fill all the other fields in  Education Successfully 
#Given seller Update university as "Andhra University"
	#And select country  as "India"
	#And choose title as "B.Sc"
	#And years degree as "5345"
	#And select year as "2007"
	#When click update button  
	#Then Education should be not be added.The alert message,"Education has been updated"should be displayed.
##Scenario:09 Test Add blank country and fill all the other fields in  Education Successfully 
#Given seller Update university as "Andhra University1234"
	#And select country  as "India"
	#And choose title as "B.Sc"
	#And years degree as "5345"
	#And select year as "2007"
	#When click update button  
	#Then Education should be not be added.The alert message,"Education has been updated"should be displayed.
	##Scenario:08 Test Add blank country and fill all the other fields in  Education Successfully 
#Given seller Update university as "Andhra University"
	#And select country  as "India"
	#And choose title as "B.Sc"
	#And years degree as "5345"
	#And select year as "2007"
	#When click update button  
	#Then Education should be not be added.The alert message,"Education has been updated"should be displayed.
