using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HtmlDispatcher
{
    class HtmlDispatcherProgram
    {
        static void Main()
        {
            ElementBuilder div =
                new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);

            Console.WriteLine();
            Console.WriteLine(HtmlDispatcher.CreateImage("some image source", "Smiley face", "this is a smiley face"));
            Console.WriteLine(HtmlDispatcher.CreateURL("www.abv.bg", "this is abv.bg", "ABV"));
            Console.WriteLine(HtmlDispatcher.CreateInput("text", "first-name", "some value"));
        }
    }
}
