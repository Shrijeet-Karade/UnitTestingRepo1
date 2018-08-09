using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }
        public Cricket()
        {
            PlayerScore = 0;
        }

        public int Scores(int runs)
        {
            PlayerScore = PlayerScore + runs;
            return PlayerScore;
        }
        public void UpdateScores(int alreadyScoredRuns)
        {
            PlayerScore = alreadyScoredRuns;
        }
    }
}
