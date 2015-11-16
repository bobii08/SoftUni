using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string[] firstArr = firstLine.Split(' ');
            string[] secondArr = secondLine.Split(' ');
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();
            foreach (var str in firstArr)
            {
                firstList.Add(int.Parse(str));
            }

            foreach (var str in secondArr)
            {
                secondList.Add(int.Parse(str));
            }

            firstList.AddRange(secondList);
            firstList.Sort();
            List<int> noDuplicates = firstList.Distinct().ToList();
            Console.WriteLine(string.Join(" ", noDuplicates));
        }
    }
}
