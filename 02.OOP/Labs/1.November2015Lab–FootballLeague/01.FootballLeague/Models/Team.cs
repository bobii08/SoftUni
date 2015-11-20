using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.FootballLeague.Models
{
    public class Team
    {
        private const int MinimumYearOfFounding = 1850;
        private string name;
        private string nickName;
        private DateTime dateOfFounding;
        private List<Player> players;

        public Team(string name, string nickName, DateTime dateOfFounding)
        {
            this.Name = name;
            this.NickName = nickName;
            this.DateOfFounding = dateOfFounding;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("name", "Name must be at least 5 characters long!");
                }
                this.name = value;
            }
        }

        public string NickName
        {
            get { return this.nickName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Nick name cannot be null or empty!");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("nick name", "Nick name must be at least 5 characters long!");
                }
                this.nickName = value;
            }
        }

        public DateTime DateOfFounding
        {
            get { return this.dateOfFounding; }
            private set
            {
                if (value.Year < MinimumYearOfFounding)
                {
                    throw new ArgumentOutOfRangeException("year of founding", "Year of founding must be bigger or equal to " + MinimumYearOfFounding);
                }
                this.dateOfFounding = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team!");
            }
            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("Name: {0}, nick name: {1}, date of founding: {2}, players: \n", this.Name, this.NickName,
                this.DateOfFounding));
            for (int i = 0; i < this.players.Count; i++)
            {
                result.Append(this.players[i].ToString());
            }

            return result.ToString();
        }
    }
}
