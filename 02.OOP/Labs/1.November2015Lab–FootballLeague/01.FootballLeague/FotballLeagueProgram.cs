using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.FootballLeague.Models;

namespace _01.FootballLeague
{
    class FotballLeagueProgram
    {
        static void Main()
        {
            string line = Console.ReadLine();
            while (line!="End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

                line = Console.ReadLine();
            }
        }
    }
}
