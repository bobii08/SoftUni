using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BookOrders
{
    class BookOrders
    {
        static void Main()
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            int amountOfBooks = 0;
            decimal totalPrice = 0;
            for (int i = 0; i < numberOfOrders; i++)
            {
                int numberOfPackets = int.Parse(Console.ReadLine());
                int booksPerPacket = int.Parse(Console.ReadLine());
                decimal currentPricePerBook = decimal.Parse(Console.ReadLine());
                int currentAmountOfBooks = numberOfPackets * booksPerPacket;
                amountOfBooks += currentAmountOfBooks;
                decimal discount = 0;
                if (numberOfPackets >= 10 && numberOfPackets <= 99)
                {
                    int firstNumber = numberOfPackets / 10;
                    discount = (decimal)0.01 * (decimal)(firstNumber + 4);
                }
                else if (numberOfPackets >= 100 && numberOfPackets < 110)
                {
                    discount = 0.14m;
                }
                else if (numberOfPackets >= 110)
                {
                    discount = 0.15m;
                }

                totalPrice += (currentAmountOfBooks * currentPricePerBook) - (currentAmountOfBooks * currentPricePerBook * discount);
            }

            Console.WriteLine(amountOfBooks);
            Console.WriteLine("{0:0.00}", totalPrice);
        }
    }
}
