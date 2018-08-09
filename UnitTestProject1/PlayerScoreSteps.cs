using CricketGame;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;
namespace UnitTestProject1
{
    [Binding]
    public class Player1ScoreSteps
    {
        private Cricket _game;
        public int alreadyScored=0;
        [When(@"Player1 starts a game")]
        [Given(@"Player1 has started a game of cricket")]
        public void WhenPlayersHasStartedAGame()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
        }
        
        [Then(@"the Player1 score should be(.*)")]
        public void ThenThePlayScoreShouldBe(int score)
        {
            // ScenarioContext.Current.Pending();
            _game.Player1Score.Should().Be(score);

        }

        [When(@"Player1 scores (.*) runs")]
        public void WhenPlayer1ScoresRuns(int runs)
        {
            int CurrentScore = _game.Scores(runs);
            
            CurrentScore.Should().Be(runs+alreadyScored);
        }

        [Given(@"Player1 has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int alreadyScoredRuns)
        {
            alreadyScored = alreadyScoredRuns;
            _game.UpdateScores(alreadyScoredRuns);
        }

    }
}
