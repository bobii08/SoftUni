using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.ExtractUrlsFromText
{
    class ExtractUrlsFromText
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("URLs:");
            foreach (var word in words)
            {
                if (word.StartsWith("http://") || word.StartsWith("www."))
                {
                    if (word.EndsWith("."))
                    {
                        string newWord = word.Remove(word.Length - 1);
                        Console.WriteLine(newWord);
                        continue;
                    }
                    Console.WriteLine(word);
                }
            }
        }
    }
}
