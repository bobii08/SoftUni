using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("numbers: ");
            double[] arr = new double[5];
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("sum = " + sum);
        }
    }
}
