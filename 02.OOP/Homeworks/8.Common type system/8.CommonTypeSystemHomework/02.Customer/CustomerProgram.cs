using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    class CustomerProgram
    {
        static void Main()
        {
            Customer pesho = new Customer("Petyr",
                "Antoniev",
                "Georgiev",
                "7289182732",
                "Sofia",
                "0921332",
                "sdsd@sds.com",
                CustomerType.Diamond);
            pesho.AddPayment(new Payment("Danyk", 200m));
            Customer pesho2 = (Customer)pesho.Clone();
            Console.WriteLine("pesho and pesho2 are equal: " + pesho.Equals(pesho2));
            pesho2.Email = "aasdsads@asdd.com";
            Console.WriteLine("pesho and pesho2 are equal: " + pesho.Equals(pesho2));
            Console.WriteLine(pesho.CompareTo(pesho2));
            pesho2.FirstName = "Ivan";
            Console.WriteLine(pesho.CompareTo(pesho2));
        }
    }
}
