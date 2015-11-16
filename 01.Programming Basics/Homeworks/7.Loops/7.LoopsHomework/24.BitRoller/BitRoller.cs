using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitRoller
{
    class BitRoller
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            string binaryRepresentation = Convert.ToString(n, 2).PadLeft(19, '0');
            char bitAtPositionF = binaryRepresentation[binaryRepresentation.Length - f - 1];
            binaryRepresentation = binaryRepresentation.Remove((binaryRepresentation.Length - f - 1), 1);
            char[] newBits = new char[18];

            for (int i = 0; i < binaryRepresentation.Length; i++)
            {
                char currentBit = binaryRepresentation[i];
                int newPosition = i + r;
                int positionToBeAdded = 0;
                if (newPosition >= binaryRepresentation.Length)
                {
                    positionToBeAdded = newPosition - binaryRepresentation.Length;
                }
                else
                {
                    positionToBeAdded = newPosition;
                }

                newBits[positionToBeAdded] = currentBit;
            }

            string str = "";
            for (int i = 0; i < newBits.Length; i++)
            {
                str += newBits[i];
            }

            str = str.Insert(binaryRepresentation.Length - f, bitAtPositionF.ToString());
            Console.WriteLine(Convert.ToInt64(str, 2));
        }
    }
}
