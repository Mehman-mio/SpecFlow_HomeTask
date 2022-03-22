Feature: LoginPositiveScenario
	In order to use the website,
	As a user
	I want to log in to the website


@positive
Scenario Outline: Successful authorization
	Given My account login page is opened
	When I have entered <Login>
	And I have also entered <Password>
	And I press login button
	Then the browser redirected me to my account page
	Then display the <Message> that I am in my account page

	Examples: 
	| Login                | Password | Message       |
	| bakukievteam@mail.ru | 123456   | Mənim hesabım |