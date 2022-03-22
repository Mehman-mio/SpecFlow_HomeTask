Feature: RegistrationPosittiveScenario
	In order to use all the features of the website
	As a user
	I want to be registered

@positive
Scenario Outline: Successful registration
	Given My registration page is opened
	When I have entered my first name <FirstName>
	And I have entered my second name <SecondName>
	And I have entered my email <Email>
	And I have entered my phone number <Phone>
	And I have entered my adress <Adress>
	And I have entered my city <City>
	And I have selected my region
	And I have entered my password <Password>
    And I have confirmed password <ConfirmPassword>
	And I have clicked the confirm button
	Then the browser redirected me to my account page
    And displayed the message <Message>

	Examples: 
	| FirstName | SecondName | Email             | Phone     | Adress          | City | Password | ConfirmPassword | Message       |
	| Taras     | Kerbut     | vpmnwnwjv@mail.ru | 055000000 | DevEducation str| Baku | 123456   | 123456          | Şəxsi kabinet |