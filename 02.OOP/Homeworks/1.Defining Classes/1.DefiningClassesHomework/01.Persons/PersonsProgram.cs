using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class PersonsProgram
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 22);
            Console.WriteLine(pesho);
            Person gosho = new Person("Gosho", 35, "gosho@abv.bg");
            Console.WriteLine(gosho);

            //uncomment the code bellow to get an error
            //Person stela = new Person("Stela", 35, "stela_abv.bg");
            //Console.WriteLine(stela);
        }
    }
}
