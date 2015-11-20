using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FootballLeague.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam
        {
            get { return this.homeTeam; }
            private set { this.homeTeam = value; }
        }

        public Team AwayTeam
        {
            get { return this.awayTeam; }
            private set { this.awayTeam = value; }
        }

        public Score Score
        {
            get { return this.score; }
            private set { this.score = value; }
        }

        public int Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }
            return (this.Score.HomeTeamGoals > this.Score.AwayTeamGoals) ? this.HomeTeam : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.HomeTeamGoals == this.Score.AwayTeamGoals;
        }

        public override string ToString()
        {
            return string.Format("Home team: {0}, away team: {1}, score: {2}, id: {3}", this.HomeTeam, this.AwayTeam,
                this.Score, this.Id);
        }
    }
}
