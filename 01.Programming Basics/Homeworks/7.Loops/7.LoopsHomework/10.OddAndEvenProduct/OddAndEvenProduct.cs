using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numsStr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = new int[numsStr.Length];
            for (int i = 0; i < numsStr.Length; i++)
            {
                nums[i] = int.Parse(numsStr[i]);
            }

            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= nums[i];
                }
                else
                {
                    evenProduct *= nums[i];
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes\nproduct = " + oddProduct);
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
            }
        }
    }
}
