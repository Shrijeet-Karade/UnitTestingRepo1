using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Test
{
    [TestClass]
    public class CricketGameTests
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Scores(3);
            Assert.IsTrue(game.PlayerScore == 3);
        }
        public void Score_InValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Scores(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }

    }
}
