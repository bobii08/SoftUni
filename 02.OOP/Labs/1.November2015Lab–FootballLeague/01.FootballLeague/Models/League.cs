using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.FootballLeague.Models
{
    public static class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return League.teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return League.matches; }
        }

        public static void AddTeam(Team team)
        {
            if (CheckIfTeamExists(team))
            {
                throw new InvalidOperationException("Team already exists!");
            }
            League.teams.Add(team);
        }

        public static void AddMatch(Match match)
        {
            if (CheckIfMathExists(match))
            {
                throw new InvalidOperationException("Match already exists!");
            }
            League.matches.Add(match);
        }

        private static bool CheckIfTeamExists(Team team)
        {
            return League.teams.Any(t => t.Name == team.Name);
        }

        private static bool CheckIfMathExists(Match match)
        {
            return League.matches.Any(m => m.Id == match.Id);
        }
    }
}
