namespace _12.ToTheStars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ToTheStars
    {
        private static void Main()
        {
            int maxSizeOfGrid = 30;
            string firstStarSystemInfo = Console.ReadLine();
            string[] strs = firstStarSystemInfo.Split();
            StarSystem firstStarSystem = new StarSystem(strs[0], double.Parse(strs[1]), double.Parse(strs[2]));
            string secondStarSystemInfo = Console.ReadLine();
            strs = secondStarSystemInfo.Split();
            StarSystem secondStarSystem = new StarSystem(strs[0], double.Parse(strs[1]), double.Parse(strs[2]));
            string thirdStarSystemInfo = Console.ReadLine();
            strs = thirdStarSystemInfo.Split();
            StarSystem thirdStarSystem = new StarSystem(strs[0], double.Parse(strs[1]), double.Parse(strs[2]));
            string normandyCoordinates = Console.ReadLine();
            strs = normandyCoordinates.Split();
            double normandyRow = double.Parse(strs[1]);
            double normandyCol = double.Parse(strs[0]);
            int steps = int.Parse(Console.ReadLine());
            StarSystem[] starSystems =
            {
                firstStarSystem, secondStarSystem, thirdStarSystem
            };

            CheckNormandyPosition(normandyRow, normandyCol, starSystems);
            for (int i = 0; i < steps; i++)
            {
                normandyRow++;
                CheckNormandyPosition(normandyRow, normandyCol, starSystems);                
            }
        }

        private static void CheckNormandyPosition(double normandyRow, double normandyCol, StarSystem[] starSystems)
        {
            for (int i = 0; i < starSystems.Length; i++)
            {
                var currentStarSystem = starSystems[i];
                if (normandyRow <= currentStarSystem.TopCornerRow &&
                    normandyRow >= currentStarSystem.TopCornerRow - 2 &&
                    normandyCol >= currentStarSystem.TopCornerCol &&
                    normandyCol <= currentStarSystem.TopCornerCol + 2)
                {
                    Console.WriteLine(currentStarSystem.Name.ToLower());
                    return;
                }
            }

            Console.WriteLine("space");
        }

        private struct StarSystem
        {
            public StarSystem(string name, double centerCol, double centerRow)
                : this()
            {
                this.Name = name;
                this.TopCornerRow = centerRow + 1;
                this.TopCornerCol = centerCol - 1;
            }

            public string Name { get; private set; }

            public double TopCornerRow { get; private set; }

            public double TopCornerCol { get; private set; }
        }
    }
}