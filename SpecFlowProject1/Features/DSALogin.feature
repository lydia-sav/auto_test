Feature: DSA Login

#Scenario: A user logs into the DSA portal
#	Given A user navigates to the DSA portal
#	When they log in
#	Then they can access their account

Scenario: A user registers
	Given A user navigates to the DSA portal
	When they select register
	And they enter their postcode 'NR32 3DA'
	And they fill in the registration form: name 'John', 'Smith'
	And they fill in the registration form: email 'zsmith@gmail.com'
	And they fill in the registration form: DOB '01/01/1990'
    And they fill in the registration form: phone number '075678328749'	
	And they fill in the registration form: select how did you hear about us? 'Student Finance England'
	And they fill in the registration form: enter address '4 Gold Coast'
	And they fill in the registration form: town or city 'London'
	And they fill in the registration form: enter password 'password1234'
	And they fill in the registration form: Click submit
	And they fill in the assessment details: Funding body 'Student Finance England'
	And they fill in the assessment details: Course 'BSc Computer Science'
	And they fill in the assessment details: course code 'CS123'
	And they fill in the assessment details: course level 'Under Graduate'
	And they fill in the assessment details: full or part time 'Full time'
	And they fill in the assessment details: course start date '01/09/2019'
	And they fill in the assessment details: Select university 'University of East Anglia'
	And they click continue
	And they fill in assessment details: Select communication preferences 'No'
	And they fill in assessment details: Select disability 'Mental health difficulties'
	And they fill in assessment details: Select difficulty areas 'Reading speed'
	And they fill in assessment details: Extra disability 'No'
	And they fill in assessment details: Received past support 'No'
	And they fill in assessment details: Has education, health and care plan in past 'No'
	And they fill in assessment details: Select requirements 'None.'
	And they fill in assessment details: Use assisting technology 'No'
    And they fill in assessment details: Select previous DSA assessment 'No'
	And they click continue
    And they fill in assessment files: Fill in funding letter later
	And they fill in assessment files: Fill in ME later
	And they click continue
	#Then they can access their account

Scenario: Student selects their preferred language as Welsh
Given A user navigates to the DSA portal
When they select their prefered language 'Cymraeg'
Then they can see the welcome screen in Welsh 'Croeso i borth ar-lein Capita DSA.'

Scenario: Student selects their preferred language as English
Given A user navigates to the DSA portal
When they select their prefered language 'Cymraeg'
When they select their prefered language 'English'
Then they can see the welcome screen in Welsh 'Welcome to the Capita DSA online portal.'

Scenario: A CST adds notes to a student's account
Given A user navigates to the CST salesforce portal
When a user logs in as a CST user
#And a user adds an account
And a user adds a note to account 'John Smith'
And a user fills in that note 'title', 'body'
Then a user can add that note to records

Scenario: A CST creates a student's account
Given A user navigates to the CST salesforce portal
When a user logs in as a CST user
And a user selects add a new student account
And a user fills in student account details
And a user saves the student account

Scenario: A student finishes their account setup
And a student navigates to their email account

Scenario: A student schedules an appointment
Given A user navigates to the student salesforce portal
When a user logs into the student portal
And  a user fills in appointment details
#make student account first(login to your gmail) lydiacapita+123@gmail.com, tic tac toe, Capita@1234