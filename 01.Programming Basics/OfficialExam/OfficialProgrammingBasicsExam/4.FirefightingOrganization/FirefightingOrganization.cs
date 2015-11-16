using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FirefightingOrganization
{
    class FirefightingOrganization
    {
        static void Main()
        {
            int fireFighters = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            int totalCountOfK = 0;
            int totalCountOfA = 0;
            int totalCountOfS = 0;
            while (inputString != "rain")
            {
                int remainingFireFighters = fireFighters;
                // count the Ks, As and Ss
                int countOfK = 0;
                int countOfA = 0;
                int countOfS = 0;
                int i = 0;
                while(true)
                {
                    int indexOfK = inputString.IndexOf('K', i);
                    if (indexOfK > -1)
                    {
                        countOfK++;
                        i = inputString.IndexOf('K', i) + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                i = 0;
                while (true)
                {
                    int indexOfA = inputString.IndexOf('A', i);
                    if (indexOfA > -1)
                    {
                        countOfA++;
                        i = inputString.IndexOf('A', i) + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                i = 0;
                while (true)
                {
                    int indexOfS = inputString.IndexOf('S', i);
                    if (indexOfS > -1)
                    {
                        countOfS++;
                        i = inputString.IndexOf('S', i) + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (remainingFireFighters >= countOfK)
                {
                    remainingFireFighters -= countOfK;
                    totalCountOfK += countOfK;
                }
                else
                {
                    totalCountOfK += remainingFireFighters;
                    remainingFireFighters = 0;
                }

                if (remainingFireFighters >= countOfA && countOfA > 0)
                {
                    remainingFireFighters -= countOfA;
                    totalCountOfA += countOfA;
                }
                else if(remainingFireFighters > 0 && countOfA > 0)
                {
                    totalCountOfA += remainingFireFighters;
                    remainingFireFighters = 0;
                }

                if (remainingFireFighters >= countOfS && countOfS > 0)
                {
                    totalCountOfS += countOfS;
                }
                else if(remainingFireFighters > 0 && countOfS > 0)
                {
                    totalCountOfS += remainingFireFighters;
                }

                inputString = Console.ReadLine();
            }

            Console.WriteLine("Kids: {0}", totalCountOfK);
            Console.WriteLine("Adults: {0}", totalCountOfA);
            Console.WriteLine("Seniors: {0}", totalCountOfS);
        }
    }
}
