using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FruitMarket
{
    class FruitMarket
    {
        static void Main()
        {
            decimal[] prices =
            {
                1.8m,
                2.75m,
                3.2m,
                1.6m,
                0.86m
            };
            string dayOfWeek = Console.ReadLine();
            List<string> products = new List<string>();
            decimal quantity1 = decimal.Parse(Console.ReadLine());
            string product1 = Console.ReadLine();
            products.Add(product1);
            decimal quantity2 = decimal.Parse(Console.ReadLine());
            string product2 = Console.ReadLine();
            products.Add(product2);
            decimal quantity3 = decimal.Parse(Console.ReadLine());
            string product3 = Console.ReadLine();
            products.Add(product3);

            bool[] areFruits =
            {
                false,
                false,
                false
            };
            bool[] isBanana =
            {
                false,
                false,
                false
            };

            decimal[] pricesOrders = new decimal[3];

            for (int i = 0; i < products.Count; i++)
            {
                string currentProduct = products[i];
                switch (currentProduct)
                {
                    case "banana":
                        pricesOrders[i] = prices[0];
                        areFruits[i] = true;
                        isBanana[i] = true;
                        break;
                    case "cucumber":
                        pricesOrders[i] = prices[1];
                        break;
                    case "tomato":
                        pricesOrders[i] = prices[2];
                        break;
                    case "orange":
                        pricesOrders[i] = prices[3];
                        areFruits[i] = true;
                        break;
                    case "apple":
                        pricesOrders[i] = prices[4];
                        areFruits[i] = true;
                        break;
                }
            }

            decimal check = 0;
            switch (dayOfWeek)
            {
                case "Friday":
                    check = ((quantity1 * pricesOrders[0]) +
                        (quantity2 * pricesOrders[1]) +
                        (quantity3 * pricesOrders[2])) * (decimal)0.9;
                    break;
                case "Sunday":
                    check = ((quantity1 * pricesOrders[0]) +
                        (quantity2 * pricesOrders[1]) +
                        (quantity3 * pricesOrders[2])) * (decimal)0.95;
                    break;
                case "Tuesday":
                    check += areFruits[0] ? (quantity1 * pricesOrders[0] * (decimal)0.8) : (quantity1 * pricesOrders[0]);
                    check += areFruits[1] ? (quantity2 * pricesOrders[1] * (decimal)0.8) : (quantity2 * pricesOrders[1]);
                    check += areFruits[2] ? (quantity3 * pricesOrders[2] * (decimal)0.8) : (quantity3 * pricesOrders[2]);
                    break;
                case "Wednesday":
                    check += areFruits[0] ? (quantity1 * pricesOrders[0]) : (quantity1 * pricesOrders[0] * (decimal)0.9);
                    check += areFruits[1] ? (quantity2 * pricesOrders[1]) : (quantity2 * pricesOrders[1] * (decimal)0.9);
                    check += areFruits[2] ? (quantity3 * pricesOrders[2]) : (quantity3 * pricesOrders[2] * (decimal)0.9);
                    break;
                case "Thursday":
                    check += isBanana[0] ? (quantity1 * pricesOrders[0] * (decimal)0.7) : (quantity1 * pricesOrders[0]);
                    check += isBanana[1] ? (quantity2 * pricesOrders[1] * (decimal)0.7) : (quantity2 * pricesOrders[1]);
                    check += isBanana[2] ? (quantity3 * pricesOrders[2] * (decimal)0.7) : (quantity3 * pricesOrders[2]);
                    break;
                default:
                    check = ((quantity1 * pricesOrders[0]) + (quantity2 * pricesOrders[1]) + (quantity3 * pricesOrders[2]));
                    break;
            }

            Console.WriteLine("{0:0.00}", check);
        }
    }
}
