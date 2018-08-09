Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

	

	Scenario: Player1 score is zero when game starts
	When Player1 starts a game
	Then the Player1 score should be 0

	Scenario: Player1 should be able to score runs
	Given Player1 has started a game of cricket
	When Player1 scores 6 runs 
	Then the Player1 score should be 6
	#Scenario: Player1 should be able to score runs
	#Given Player1 has started a game of cricket
	#When Player1 scores 4 runs 
	#Then the Player1 score should be 4
	#Scenario: Player2 should be able to score runs
	#Given Player1 has started a game of cricket
	#When Player1 scores 3 runs 
	#Then the Player1 score should be 3
	#Scenario: Player2 should be able to score runs
	#Given Player1 has started a game of cricket
	#When Player1 scores 2 runs 
	#Then the Player1 score should be 2
	#Scenario: Player2 should be able to score runs
	#Given Player1 has started a game of cricket
	#When Player1 scores 1 runs 
	#Then the Player1 score should be 1


	Scenario: Player2 score is zero when game starts
	When Player2 starts a game
	Then the Player2 score should be 0

	Scenario: Player2 should be able to score runs
	Given Player2 has started a game of cricket
	When Player2 scores 6 runs 
	Then the Player2 score should be 6
	#Scenario: Player2 should be able to score runs
	#Given Player2 has started a game of cricket
	#When Player2 scores 4 runs 
	#Then the Player2 score should be 4
	#Scenario: Player2 should be able to score runs
	#Given Player2 has started a game of cricket
	#When Player2 scores 3 runs 
	#Then the Player2 score should be 3
	#Scenario: Player2 should be able to score runs
	#Given Player2 has started a game of cricket
	#When Player2 scores 2 runs 
	#Then the Player2 score should be 2
	#Scenario: Player2 should be able to score runs
	#Given Player2 has started a game of cricket
	#When Player2 scores 1 runs 
	#Then the Player2 score should be 1

	Scenario: Player2 score should not get updated when he gets out
	Given Player2 has started a game of cricket
	And Player2 has got out
	When  Player2 scores 2 runs
	Then the Player2 score should be 0

	Scenario: Player1 score should not get updated when he gets out
	Given Player1 has started a game of cricket
	And Player1 has got out
	When  Player1 scores 2 runs
	Then the Player1 score should be 0

#Player 1 should be declared the winner if he scores more than Player 2

#Game should be declared a Tie if both players have the same total
Scenario: Player1 should be declared the winner if he scores more than Player2
Given Player1 has started a game of cricket
And Player1 has scored 2 runs
And Player1 has got out
And Player2 has scored 6 runs
And Player2 has got out 
When Both Player are Out
Then Player 2 is the winner

Scenario: Scores are tied
Given Player1 has started a game of cricket
And Player1 has scored 6 runs
And Player1 has got out
And Player2 has scored 6 runs
And Player2 has got out 
When Both Player are Out
Then the game is tied and result is 3
