using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public int flag1 = 0;
        public int flag2 = 0;

        public Cricket()
        {
            Player1Score = 0;
            Player2Score = 0;
        }

        public int Player1Scores(int runs)
        {
            if (flag1 == 1)
            {
                Player1Score = Player1Score + runs;
               
            }
            return Player1Score;
        }
        public int Player2Scores(int runs)
        {
            if (flag2 == 1)
            {
                Player2Score = Player2Score + runs;
            }
            return Player2Score;
        }

        public void UpdatePlayer1Score(int alreadyScoredRuns)
        {
            if (flag1 == 1)
            {
                Player1Score = alreadyScoredRuns;
            }
        }
        public void UpdatePlayer2Score(int alreadyScoredRuns)
        {
            if (flag2 == 1)
            {
                Player2Score = alreadyScoredRuns;
            }
        }
        public int WinnerResult()
        {
            if(Player2Score>Player1Score)
            {
                return 2;
            }
            else if(Player1Score>Player2Score)
            {
                return 1;
            }
            else
            {
                return 3;
            }
        }

    }
}
