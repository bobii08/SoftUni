using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class PcCatalogProgram
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Computer[] computers = new Computer[]
            {
                new Computer("Pesho's computer", 1000m, new Component[]
                {
                    new Component("Processor", 100m),
                    new Component("Graphics card", 300m),
                    new Component("Motherboard", 250m, "this mother board is really good")
                }),
                new Computer("Gosho's computer", 2200m, new Component[]
                {
                    new Component("Processor", 150m),
                    new Component("Graphics card", 120m),
                    new Component("Motherboard", 150m, "this mother board is really good")
                }),
                new Computer("Stefan's computer", 1499m, new Component[]
                {
                    new Component("Processor", 40m),
                    new Component("Graphics card", 500m),
                    new Component("Motherboard", 750m, "this mother board is really good"),
                })
            };

            while (true)
            {
                bool hasChanged = false;
                for (int i = 0; i < computers.Length - 1; i++)
                {
                    if (computers[i].Price > computers[i + 1].Price)
                    {
                        Swap(ref computers[i], ref computers[i + 1]);
                        hasChanged = false;
                    }
                }

                if (!hasChanged)
                {
                    break;
                }
            }

            foreach (var computer in computers)
            {
                computer.DisplayInfo();
                Console.WriteLine();
            }
        }

        private static void Swap(ref Computer v1, ref Computer v2)
        {
            var oldComputer = v1;
            v1 = v2;
            v2 = oldComputer;
        }
    }
}
