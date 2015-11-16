using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string[] firstStrings = firstLine.Split(' ');
            string[] secondStrings = secondLine.Split(' ');
            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();

            for (int i = 0; i < firstStrings.Length; i++)
            {
                firstList.Add(firstStrings[i]);
            }

            for (int i = 0; i < secondStrings.Length; i++)
            {
                secondList.Add(secondStrings[i]);
            }

            for (int i = 0; i < secondStrings.Length; i++)
            {
                string wordToBeRemoved = secondStrings[i];
                if (firstList.Contains(wordToBeRemoved))
                {
                    while (true)
                    {
                        firstList.Remove(wordToBeRemoved);
                        if (!firstList.Contains(wordToBeRemoved))
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", firstList));
        }
    }
}
