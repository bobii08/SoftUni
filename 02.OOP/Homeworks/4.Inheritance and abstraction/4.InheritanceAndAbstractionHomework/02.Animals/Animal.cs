using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    abstract class Animal : ISoundProducible
    {
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public abstract void ProduceSound();
    }
}
