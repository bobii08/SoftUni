namespace Blobs.IO
{
    using System;
    using Interfaces;

    public class ConsoleWriter : IOutputWriter
    {
        public void Write(string line)
        {
            Console.Write(line);
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
