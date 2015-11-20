using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FootballLeague.Models
{
    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }

        public int HomeTeamGoals
        {
            get { return this.homeTeamGoals; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("home team goals", "Home team goals cannot be negative!");
                }
                this.homeTeamGoals = value;
            }
        }

        public int AwayTeamGoals
        {
            get { return this.awayTeamGoals; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("away team goals", "Away team goals cannot be negative!");
                }
                this.awayTeamGoals = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Home team goals: {0}, away team goals: {1}", this.HomeTeamGoals, this.AwayTeamGoals);
        }
    }
}
