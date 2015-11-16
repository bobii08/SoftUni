using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OddAndEvenJumps
{
    class OddAndEvenJumps
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            // there may be a special case when inputString.Length = 1
            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());

            StringBuilder strB = new StringBuilder(inputString);
            while (strB.ToString().Contains(' '))
            {
                strB.Remove(strB.ToString().IndexOf(' '), 1);    
            }
            StringBuilder oddLetters = new StringBuilder();
            StringBuilder evenLetters = new StringBuilder();

            for (int i = 0; i < strB.Length; i++)
            {
                char currentChar = strB.ToString()[i];
                char chToLower = currentChar.ToString().ToLower()[0];
                if (i % 2 == 0)
                {
                    oddLetters.Append(chToLower);
                }
                else
                {
                    evenLetters.Append(chToLower);
                }
            }

            long oddSum = 0;
            long evenSum = 0;

            for (int i = 0; i < oddLetters.Length; i++)
            {
                int currentCounter = 1;
                while (true)
                {
                    if (currentCounter < oddJump)
                    {
                        oddSum += oddLetters[i++];
                        currentCounter++;
                        if (i == oddLetters.Length)
                        {
                            break;
                        }
                    }
                    else if (currentCounter == oddJump)
                    {
                        oddSum *= oddLetters[i];
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < evenLetters.Length; i++)
            {
                int currentCounter = 1;
                while (true)
                {
                    if (currentCounter < evenJump)
                    {
                        evenSum += evenLetters[i++];
                        currentCounter++;
                        if (i == evenLetters.Length)
                        {
                            break;
                        }
                    }
                    else if (currentCounter == evenJump)
                    {
                        evenSum *= evenLetters[i];
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            string oddSumInHex = Convert.ToString(oddSum, 16).ToUpper();
            string evenSumInHex = Convert.ToString(evenSum, 16).ToUpper();
            Console.WriteLine("Odd: " + oddSumInHex);
            Console.WriteLine("Even: " + evenSumInHex);
        }
    }
}
