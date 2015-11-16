using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            string[] faces =
            {
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "J",
                "Q",
                "K",
                "A"
            };

            string[] suits =
            {
                "♣",
                "♦",
                "♥",
                "♠"
            };

            for (int i = 0; i < faces.Length; i++)
            {
                string currentFace = faces[i];
                for (int j = 0; j < suits.Length; j++)
                {
                    string currentSuit = suits[j];
                    Console.Write(currentFace+currentSuit+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
