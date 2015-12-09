using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public class AnimalsProgram
    {
        static void Main()
        {
            Animal[] arrayOfAnimals = new Animal[]
            {
                new Tomcat("Tom", 12),
                new Frog("Froggy", 5, "male"), 
                new Dog("Sharo", 6, "male"), 
                new Kitten("Kitty", 15), 
            };

            var averageAge = arrayOfAnimals.Average(a => a.Age);
            Console.WriteLine("The average age of the animals is: " + averageAge);
        }
    }
}
