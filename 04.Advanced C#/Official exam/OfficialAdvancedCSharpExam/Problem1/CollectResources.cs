namespace Problem1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class CollectResources
    {
        private static void Main()
        {
            var resources = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            bool[] bools = null;
            int n = int.Parse(Console.ReadLine());
            ulong maxResources = 0;
            List<string> validResources = new List<string>() { "stone", "gold", "wood", "food" };
            for (int i = 0; i < n; i++)
            {
                bools = new bool[resources.Length];
                string[] startAndStep = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                long start = long.Parse(startAndStep[0]);
                long step = long.Parse(startAndStep[1]);
                long currentPos = start;
                ulong currentResources = 0;
                while (true)
                {
                    if (bools[currentPos])
                    {
                        if (currentResources > maxResources)
                        {
                            maxResources = currentResources;
                        }

                        break;
                    }

                    string currentResourse = resources[currentPos];
                    string[] args =
                        currentResourse.Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (args.Length == 2)
                    {
                        if (validResources.Contains(args[0]))
                        {
                            bools[currentPos] = true;
                            currentResources += ulong.Parse(args[1]);
                        }
                    }
                    else
                    {
                        if (validResources.Contains(args[0]))
                        {
                            bools[currentPos] = true;
                            currentResources++;
                        }
                    }

                    currentPos += step;
                    currentPos = currentPos % resources.Length;
                }
            }

            Console.WriteLine(maxResources);
        }
    }
}