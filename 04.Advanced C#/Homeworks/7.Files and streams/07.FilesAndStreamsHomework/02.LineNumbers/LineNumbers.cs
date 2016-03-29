namespace _02.LineNumbers
{
    using System.IO;

    internal class LineNumbers
    {
        private static void Main()
        {
            using (var streamReader = new StreamReader("../../textFile.txt"))
            {
                using (var streamWriter = new StreamWriter("../../resultTxtFile.txt"))
                {
                    string line = streamReader.ReadLine();
                    int lineNumber = 1;
                    while (line != null)
                    {
                        streamWriter.WriteLine(lineNumber + " " + line);
                        line = streamReader.ReadLine();
                        lineNumber++;
                    }
                }
            }
        }
    }
}