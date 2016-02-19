 // "<ul>\n\t<li>\n\t<a href="http://softuni.bg">SoftUni</a>\n\t</li>\n</ul>"

namespace _02.ReplaceHTMLTag
{
    using System;
    using System.Text.RegularExpressions;

    internal class ReplaceHTMLTag
    {
        private static void Main()
        {
            // string input = "<ul>\n  <li>\n    <a href='http://softuni.bg'>SoftUni</a>\n  </li>\n</ul>"; -> input with single quotes
            string input = "<ul>\n  <li>\n    <a href=\"http://softuni.bg\">SoftUni</a>\n  </li>\n</ul>";
            string pattern = @"</a>";
            Regex regex = new Regex(pattern);
            input = regex.Replace(input, "[/URL]");
            pattern = @"(<a).+(""|').+\2(>)";
            regex = new Regex(pattern);
            var matches = regex.Matches(input);
            input = Regex.Replace(input, matches[0].Groups[1].Value, "[URL");
            input = Regex.Replace(input, matches[0].Groups[2].Value, string.Empty);
            pattern = @">\b";
            regex = new Regex(pattern);
            input = regex.Replace(input, "]");
            Console.WriteLine(input);
        }
    }
}