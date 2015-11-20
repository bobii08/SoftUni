using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FootballLeague.Models
{
    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    LeagueManager.AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                    LeagueManager.AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam":
                    var team = League.Teams.First(t => t.Name == inputArgs[5]);
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), team);
                    break;
                default:
                    throw new InvalidOperationException("You've called an invalid operation!");
            }
        }

        private static void AddPlayerToTeam(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team)
        {
            team.AddPlayer(new Player(firstName, lastName, salary, dateOfBirth, team));
            Console.WriteLine("Player successfully added to team!");
        }

        private static void AddTeam(string name, string nickName, DateTime dateOfFounding)
        {
            League.AddTeam(new Team(name, nickName, dateOfFounding));
            Console.WriteLine("Team successfully added!");
        }

        private static void AddMatch(int id, string homeTeamName, string awayTeamName, int homeTeamGoals, int awayTeamGoals)
        {
            var homeTeam = League.Teams.First(t => t.Name == homeTeamName);
            var awayTeam = League.Teams.First(t => t.Name == awayTeamName);
            League.AddMatch(new Match(homeTeam, awayTeam, new Score(homeTeamGoals, awayTeamGoals), id));
            Console.WriteLine("Match successfully added!");
        }
    }
}
