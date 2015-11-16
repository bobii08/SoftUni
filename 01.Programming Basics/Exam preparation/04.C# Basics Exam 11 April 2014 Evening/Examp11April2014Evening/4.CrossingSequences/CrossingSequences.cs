using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CrossingSequences
{
    class CrossingSequences
    {
        private static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string thirdLine = Console.ReadLine();
            string fourthLine = Console.ReadLine();
            string fifthLine = Console.ReadLine();
            int firstTribonacciNum = int.Parse(firstLine);
            int secondTribonacciNum = int.Parse(secondLine);
            int thirdTribonacciNum = int.Parse(thirdLine);
            int startingNumber = int.Parse(fourthLine);
            int step = int.Parse(fifthLine);
            
            List<int> tribonacciSequence = new List<int>();
            if (startingNumber == firstTribonacciNum || 
                startingNumber == secondTribonacciNum || 
                startingNumber == thirdTribonacciNum)
            {
                Console.WriteLine(startingNumber);
                return;
            }

            tribonacciSequence.Add(firstTribonacciNum);
            tribonacciSequence.Add(secondTribonacciNum);
            tribonacciSequence.Add(thirdTribonacciNum);
            int biggestNumInTribonacciSequence = 0;
            while (true)
            {
                int fourthTribonacciNum = firstTribonacciNum + secondTribonacciNum + thirdTribonacciNum;
                if (fourthTribonacciNum > 1000000)
                {
                    biggestNumInTribonacciSequence = fourthTribonacciNum;
                    break;
                }

                tribonacciSequence.Add(fourthTribonacciNum);
                firstTribonacciNum = secondTribonacciNum;
                secondTribonacciNum = thirdTribonacciNum;
                thirdTribonacciNum = fourthTribonacciNum;
            }

            //List<int> firstSequence = new List<int>();
            //List<int> numberSpiralSequence = new List<int>();
            while (true)
            {
                //firstSequence.Add(startingNumber);
                if (tribonacciSequence.Contains(startingNumber))
                {
                    Console.WriteLine(startingNumber);
                    return;
                }
                startingNumber += step;
                if (startingNumber > biggestNumInTribonacciSequence)
                {
                    break;
                }
                
            }
            /*
            foreach (var num in tribonacciSequence)
            {
                if (firstSequence.Contains(num))
                {
                    Console.WriteLine(num);
                    return;
                }
            }
             * */
            /*
            int position = 0;
            int count = 1;
            int times = 1;
            while (true)
            {
                int numberToBeAdded = firstSequence[position];
                numberSpiralSequence.Add(numberToBeAdded);
                position += count;
                times++;
                if (times == 3)
                {
                    times -= 2;
                    count++;
                }

                if (position > firstSequence.Count)
                {
                    break;
                }
            }

            foreach (var num in tribonacciSequence)
            {
                if (numberSpiralSequence.Contains(num))
                {
                    Console.WriteLine(num);
                    return;
                }
            }
             * */

            Console.WriteLine("No");
        }
    }
}
