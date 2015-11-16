using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitBuilder
{
    class BitBuilder
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string posStr = Console.ReadLine();
            int position = 0;
            if (!int.TryParse(posStr, out position))
            {
                Console.WriteLine(number);
                return;
            }
            string command = Console.ReadLine();


            string numberStr = Convert.ToString(number, 2).PadLeft(64, '0');
            StringBuilder numberInBin = new StringBuilder(numberStr);
            while (command != "quit")
            {
                switch (command)
                {
                    case "flip":
                        if (numberInBin[numberInBin.Length - position - 1] == '1')
                        {
                            int testLength = numberInBin.Length;
                            numberInBin.Remove(numberInBin.Length - position - 1, 1);
                            testLength = numberInBin.Length;
                            numberInBin.Insert(numberInBin.Length - position, "0");
                        }
                        else
                        {
                            numberInBin.Remove(numberInBin.Length - position - 1, 1);
                            numberInBin.Insert(numberInBin.Length - position, "1");
                        }
                        break;
                    case "remove":
                        numberInBin.Remove(numberInBin.Length - position - 1, 1);
                        numberInBin.Insert(0, "0");
                        break;
                    case "insert":
                        numberInBin.Insert(numberInBin.Length - position, "1");
                        break;
                    case "skip":
                        break;
                }

                string positionStr = Console.ReadLine();
                position = 0;
                if (!int.TryParse(positionStr, out position))
                {
                    break;
                }
                
                command = Console.ReadLine();
            }


            Console.WriteLine(Convert.ToInt64(numberInBin.ToString(), 2));
        }
    }
}
