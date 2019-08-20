Feature: New Registration
	I would like a user to be Registered on the Nopcommerce website 
	after filling in the Registration form 


Scenario: Complete Registraion 
	Given the user is on the Nopcommerce website 
	And the user taps on the Register button 
	When the user fills in all the details on the page 
	And taps on the Register button
	Then the user should be registered and see a Register success message 
