Feature: PlayerScore
	In order to enjoy a game
	As a player
	I want to be told my score

@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

	Scenario: Player score is zero when game starts
	When Player starts a game
	Then the Player score should be 0

	Scenario:  Player should be able to score runs
	Given Player has started a game of cricket
	When Player scores 4 runs
	Then the Player score should be 4

	Scenario:  Player should be able to score runs multiple times
	Given Player has started a game of cricket
	And Player has scored 4 runs
	When Player scores 3 runs
	Then the Player score should be 7


