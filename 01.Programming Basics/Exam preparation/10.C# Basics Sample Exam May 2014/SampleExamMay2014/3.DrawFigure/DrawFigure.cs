using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DrawFigure
{
    class DrawFigure
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            // first part
            int dots = 0;
            int asteriks = n;
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('*', asteriks));
                Console.WriteLine(new string('.', dots));
                dots++;
                asteriks -= 2;
            }

            //second part
            asteriks = 3;
            dots = (n - asteriks) / 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('*', asteriks));
                Console.WriteLine(new string('.', dots));
                dots--;
                asteriks += 2;
            }
        }
    }
}
