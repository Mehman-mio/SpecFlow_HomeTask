Feature: LoginNegativeScenario
	In order to avoid using the website of unregistered users
	As a website administrator
	I want unregistered users to not be able to log in

@negative
Scenario Outline: Impossibility of authorization with invalid data
	Given My account login page is opened
	When I have entered login <Login>
	And I have also entered password <Password>
	And I have clicked login button
	Then Error message <Error_Message> is displayed

	Examples: 
	| Login   | Password | Error_Message                                         |
	| invalid | invalid  | E-mail və/və ya şifrə xanaları yanlış doldurulmuşdur! |
	| Mehman  |          | E-mail və/və ya şifrə xanaları yanlış doldurulmuşdur! |
	|         | Rustam   | E-mail və/və ya şifrə xanaları yanlış doldurulmuşdur! |                                         

