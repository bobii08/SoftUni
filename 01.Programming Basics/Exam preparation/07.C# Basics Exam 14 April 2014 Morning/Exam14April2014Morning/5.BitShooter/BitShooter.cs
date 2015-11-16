using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitShooter
{
    class BitShooter
    {
        static void Main()
        {
            /*
            string test = "10110101010";
            int center = 5;
            int size = 3;
            int indexInStr = test.Length - center - 1;
            int startIndexToRemove = indexInStr - (size / 2);
            int strtIndexToInsert = startIndexToRemove;
            test = test.Remove(startIndexToRemove, size);
            test = test.Insert(strtIndexToInsert, new string('0', size));
            Console.WriteLine(test);
            */
            ulong integer = ulong.Parse(Console.ReadLine());
            string binaryRepresentation = Convert.ToString((long)integer, 2).PadLeft(64, '0');

            for (int i = 0; i < 3; i++)
            {
                string currentLine = Console.ReadLine();
                string[] arrOfStrNumbers = currentLine.Split(' ');
                int center = Convert.ToInt32(arrOfStrNumbers[0]);
                if (center < 0 || center > 63)
                {
                    break;
                }
                int size = Convert.ToInt32(arrOfStrNumbers[1]);
                int indexInStr = binaryRepresentation.Length - center - 1;
                int startIndexToRemove = indexInStr - (size / 2);
                int startIndexToInsert = startIndexToRemove;
                if (startIndexToRemove + size >= binaryRepresentation.Length)
                {
                    int toBeSubstracted = (startIndexToRemove + size) - binaryRepresentation.Length;
                    size -= toBeSubstracted;
                }

                binaryRepresentation = binaryRepresentation.Remove(startIndexToRemove, size);
                binaryRepresentation = binaryRepresentation.Insert(startIndexToInsert, new string('0', size));
            }

            string leftSide = binaryRepresentation.Substring(0, 32);
            string rightSide = binaryRepresentation.Substring(32, 32);
            int leftSideOnes = 0;
            int rightSideOnes = 0;
            foreach (var ch in leftSide)
            {
                if (ch == '1')
                {
                    leftSideOnes++;
                }
            }

            foreach (var ch in rightSide)
            {
                if (ch == '1')
                {
                    rightSideOnes++;
                }
            }

            Console.WriteLine("left: " + leftSideOnes);
            Console.WriteLine("right: " + rightSideOnes);
        }
    }
}
