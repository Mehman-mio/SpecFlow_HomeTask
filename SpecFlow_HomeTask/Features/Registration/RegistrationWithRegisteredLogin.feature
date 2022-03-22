Feature: RegistrationWithRegisteredLogin
	In order to avoid registration of already registered users
	As a website administrator
	I want to registered users to not be able to register again

@negative
Scenario Outline: Warning messages about already registered users
	Given My registration page is opened
	When I have entered my first name <FirstName>
	And I have entered my second name <SecondName>
	And I have entered my already registered login <Email>
	And I have entered my phone number <Phone>
	And I have entered my adress <Adress>
	And I have entered my city <City>
	And I have selected my region
	And I have entered my password <Password>
    And I have confirmed password <ConfirmPassword>
	And I have clicked the confirm button
	Then displayed warning <Message> that I am already registered

	Examples: 

    | FirstName | SecondName | Email                | Phone     | Adress          | City | Password | ConfirmPassword | Message                                 |
	| Taras     | Kerbut     | bakukievteam@mail.ru | 055000000 | DevEducation str| Baku | 123456   | 123456          | Bu E-Mail artıq qeydiyyatdan keçmişdir! |
