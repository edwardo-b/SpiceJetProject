Feature: BookingTrip

A short summary of the feature

@UI_test
@testcaseId_1234
Scenario: Booking a one way trip
	Given I launch the app url 
	When Ensure one way trip and round trips are selectable
	And I Select oneway trips
	And I fill in the depature "Mum" and arrival "Del" locations
	* I click the depature date field
	* I select the depature date
	* I select the number of passengers eg 2 adults, 1 child, 2 infants
	* I select currency eg pounds
	* Click search flight button
	Then I am redirected to the flights page.
	Given I Ensure prices are displayed and I select a price
	When I click on the continue button
	* I fill all contact details by providing Title, FirstName/MiddleName "fname", Lastname "lname" contactPrefix "unite"  contact no "7901040084", Email address "edtest@mail.com", Country "United Kingdom",Town or city "Manchester"
	* I ensure I tick I am flying as a passenger cleckbox 
	* I enter all passenger details, by selecting title and filling in the  FirstName/MiddleName "fname", Lastname "lname" Country "unite" contact no "7901040084", Email address "email@mail.com"
	Given I add no addons
	When I enter card details by filling card number "4324398875533977" , card Holder name "testEd", expiry date "Jan", "2026", "123"
	When I tick T&C checkbox
	* Click on proceed to pay button


@UI_test
@testcaseId_12345
Scenario: Login into account with mobile number 
 Given I launch the app url
 When I click on the login button
 And Tick by mobile number
 And I select country code eg +44 "unite"
 And I enter address '7901040084'
 And I enter password 'Welcome123'
 Then I will logged in successfully


 @UI_test
@testcaseId_12347
Scenario: Login into account with email address
 Given I launch the app url
 When I click on the login button
 And Tick email login option
 And I enter address 'test@mail.com'
 And I enter password 'Welcome123'
 Then I will logged in successfully
