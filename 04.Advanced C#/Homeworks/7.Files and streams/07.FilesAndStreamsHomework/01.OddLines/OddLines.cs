namespace _01.OddLines
{
    using System;
    using System.IO;

    internal class OddLines
    {
        private static void Main()
        {
            using (var streamReader = new StreamReader("../../textFile.txt"))
            {
                int counter = 1;
                string line = streamReader.ReadLine();
                while (line != null)
                {
                    line = streamReader.ReadLine();

                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    
                    counter++;
                }
            }
        }
    }
}