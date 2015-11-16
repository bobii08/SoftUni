using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.MagicDates
{
    class MagicDates
    {
        static void Main()
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());

            DateTime startingDate = new DateTime(startYear, 1, 1);
            DateTime endingDate = new DateTime(endYear, 12, 31);
            List<string> magicSequencesOfNumbers = new List<string>();
            for (DateTime date = startingDate; date <= endingDate; date = date.AddDays(1))
            {
                int days = date.Day;
                int month = date.Month;
                int year = date.Year;
                string strToBeAdded = ((days < 10) ? ("0" + days) : days.ToString()) + "" +
                    ((month < 10) ? ("0" + month) : month.ToString()) + "" +
                    year;
                int currentSum = 0;
                for (int i = 0; i < strToBeAdded.Length - 1; i++)
                {
                    int firstNum = int.Parse(strToBeAdded[i].ToString());
                    for (int j = i + 1; j < strToBeAdded.Length; j++)
                    {
                        int secondNum = int.Parse(strToBeAdded[j].ToString());
                        currentSum += (firstNum * secondNum);
                    }
                }

                if (currentSum == magicWeight)
                {
                    magicSequencesOfNumbers.Add(strToBeAdded);
                }
            }

            if (magicSequencesOfNumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            foreach (var str in magicSequencesOfNumbers)
            {
                string day = str.Substring(0, 2);
                string month = str.Substring(2, 2);
                string year = str.Substring(4);
                Console.WriteLine(day + "-" + month + "-" + year);
            }
        }
    }
}
