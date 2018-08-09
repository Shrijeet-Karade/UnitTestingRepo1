Feature: Player1Score
	In order to enjoy a game
	As a player
	I want to be told my score

@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

	Scenario: Player1 score is zero when game starts
	When Player1 starts a game
	Then the Player1 score should be 0

	Scenario:  Player1 should be able to score runs
	Given Player1 has started a game of cricket
	When Player1 scores 4 runs
	Then the Player1 score should be 4 

	Scenario:  Player1 should be able to score runs multiple times
	Given Player1 has started a game of cricket
	And Player1 has scored 4 runs
	When Player1 scores 3 runs
	Then the Player1 score should be 7



