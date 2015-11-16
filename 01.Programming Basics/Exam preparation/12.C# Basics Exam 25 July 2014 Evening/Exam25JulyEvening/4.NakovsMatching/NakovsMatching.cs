using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NakovsMatching
{
    class NakovsMatching
    {
        static long CalculateWeight(string word)
        {
            long result = 0;
            for (int i = 0; i < word.Length; i++)
            {
                result += word[i];
            }

            return result;
        }

        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            long d = long.Parse(Console.ReadLine());

            List<string> firstWordSplitsLeftSide = new List<string>();
            List<string> firstWordSplitsRightSide = new List<string>();
            List<string> secondWordSplitsLeftSide = new List<string>();
            List<string> secondWordSplitsRightSide = new List<string>();

            for (int i = 0; i < a.Length - 1; i++)
            {
                firstWordSplitsLeftSide.Add(a.Substring(0, i + 1));
                firstWordSplitsRightSide.Add(a.Substring(i + 1));
            }

            for (int i = 0; i < b.Length - 1; i++)
            {
                secondWordSplitsLeftSide.Add(b.Substring(0, i + 1));
                secondWordSplitsRightSide.Add(b.Substring(i + 1));
            }

            long weightToBeCompared = 0;
            long weightALeft = 0;
            long weightARight = 0;
            long weightBLeft = 0;
            long weightBRight = 0;
            int counter = 0;
            for (int i = 0; i < firstWordSplitsLeftSide.Count; i++)
            {
                string aLeft = firstWordSplitsLeftSide[i];
                string aRight = firstWordSplitsRightSide[i];
                for (int j = 0; j < secondWordSplitsLeftSide.Count; j++)
                {
                    string bLeft = secondWordSplitsLeftSide[j];
                    string bRight = secondWordSplitsRightSide[j];
                    weightALeft = CalculateWeight(aLeft);
                    weightARight = CalculateWeight(aRight);
                    weightBLeft = CalculateWeight(bLeft);
                    weightBRight = CalculateWeight(bRight);
                    weightToBeCompared = Math.Abs((weightALeft * weightBRight) - (weightARight * weightBLeft));
                    if (weightToBeCompared <= d)
                    {
                        Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", 
                            aLeft, aRight, bLeft, bRight, weightToBeCompared);
                        counter++;
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
