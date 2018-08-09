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
        [When(@"Player2 starts a game")]
        [Given(@"Player2 has started a game of cricket")]
        [When(@"Player1 starts a game")]
        [Given(@"Player1 has started a game of cricket")]
        public void WhenPlayerHasStartedAGame()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
            _game.flag1 = 1;
            _game.flag2 = 1;
        }
        
        [Then(@"the Player1 score should be(.*)")]
        public void ThenThePlayer1ScoreShouldBe(int score)
        {
            // ScenarioContext.Current.Pending();
            _game.Player1Score.Should().Be(score);

        }

        [When(@"Player1 scores (.*) runs")]
        public void WhenPlayer1ScoresRuns(int runs)
        {
            _game.Player1Scores(runs);

        }
        [Then(@"the Player2 score should be(.*)")]
        public void ThenThePlayer2ScoreShouldBe(int score)
        {
            // ScenarioContext.Current.Pending();
            _game.Player2Score.Should().Be(score);

        }
        [When(@"Player2 scores (.*) runs")]
        public void WhenPlayer2ScoresRuns(int runs)
        {
            _game.Player2Scores(runs);

           
        }

        [Given(@"Player1 has scored (.*) runs")]
        public void GivenPlayer1HasScoredRuns(int alreadyScoredRuns)
        {
            alreadyScored = alreadyScoredRuns;
            _game.UpdatePlayer1Score(alreadyScoredRuns);
        }

        [Given(@"Player2 has scored (.*) runs")]
        public void GivenPlayer2HasScoredRuns(int alreadyScoredRuns)
        {
            alreadyScored = alreadyScoredRuns;
            _game.UpdatePlayer2Score(alreadyScoredRuns);
        }


       
        [Given(@"Player1 has got out")]
        public void GivenPlayer1HasGotOut()
        {
            _game.flag1 = 0;
        }
        [Given(@"Player2 has got out")]
        public void GivenPlayer2HasGotOut()
        {
            _game.flag2 = 0;
        }
        [When(@"Both Player are Out")]
        public void WhenBothPlayerAreOut()
        {
            _game.flag1.Should().Be(0);
            _game.flag2.Should().Be(0);
        }

        [Then(@"Player (.*) is the winner")]
        public void ThenPlayerIsTheWinner(int check)
        {
            int result = _game.WinnerResult();
            check.Should().Be(result);
           
        }
        [Then(@"the game is tied and result is (.*)")]
        public void ThenTheGameIsTiedAndResultIs(int check)
        {
            int result = _game.WinnerResult();
            check.Should().Be(result);
        }


    }
}
