using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Test
{
    [TestClass]
    public class CricketGameTests
    {
        [TestMethod]
        public void Player1Score_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.Player1Score == 0);
        }
        public void Score_ValidRuns_ShouldUpdatePlayer1Score()
        {
            var game = new Cricket();
            game.Player1Scores(3);
            Assert.IsTrue(game.Player1Score == 3);
        }
        public void Score_InValidRuns_ShouldUpdatePlayer1Score()
        {
            var game = new Cricket();
            game.Player1Scores(7);
            Assert.IsTrue(game.Player1Score == 0);
        }

    }
}
