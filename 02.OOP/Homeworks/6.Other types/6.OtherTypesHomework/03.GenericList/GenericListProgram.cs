using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    class GenericListProgram
    {
        static void Main()
        {
            GenericList<int> listOfIntegers = new GenericList<int>();
            listOfIntegers.Add(28);
            listOfIntegers.Add(-4);
            listOfIntegers.Add(91);
            Console.WriteLine("listOfIntegers at this moment: " + listOfIntegers);
            Console.WriteLine("Element at index 1 is: " + listOfIntegers.AccessElementByIndex(1));
            listOfIntegers.RemoveElementByIndex(2);
            Console.WriteLine("listOfIntegers after removing the element at index 2: " + listOfIntegers);
            listOfIntegers.Add(3214);
            listOfIntegers.Add(-144);
            Console.WriteLine("listOfIntegers after adding some elements: " + listOfIntegers);
            listOfIntegers.InsertElementAtGivenPosition(2, 555);
            Console.WriteLine("listOfIntegers at this moment: " + listOfIntegers);
            listOfIntegers[0] = -1234;
            Console.WriteLine("listOfIntegers at this moment: " + listOfIntegers);
            Console.WriteLine("Element 555 is at index: " + listOfIntegers.FindElementIndexByGivenValue(555));
            Console.WriteLine("Element 3214 is at index: " + listOfIntegers.FindElementIndexByGivenValue(3214));
            Console.WriteLine("Element -11111 is at index: " + listOfIntegers.FindElementIndexByGivenValue(-11111));
            Console.WriteLine("The list contains the value -144: " + listOfIntegers.ContainsValue(-144));
            listOfIntegers.Clear();
            Console.WriteLine("listOfIntegers after clear command: " + listOfIntegers);

            Console.WriteLine();
            Type type = typeof(GenericList<>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (var version in allAttributes)
            {
                VersionAttribute v = version as VersionAttribute;
                if (v != null)
                {
                    Console.WriteLine("Version of GenericList<>: " + v.Version);
                }
            }
        }
    }
}
