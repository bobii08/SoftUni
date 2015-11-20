using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HtmlDispatcher
{
    public class ElementBuilder
    {
        private string element;

        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
            this.element = string.Format("<{0}></{0}>", this.ElementName);
        }

        public string ElementName { get; set; }

        public void AddAttribute(string attribute, string value)
        {
            int indexOfFirstBiggerThanSign = this.element.IndexOf(">");
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < indexOfFirstBiggerThanSign; i++)
            {
                strB.Append(this.element[i]);
            }
            strB.AppendFormat(@" {0}=""{1}""", attribute, value);
            for (int i = indexOfFirstBiggerThanSign; i < this.element.Length; i++)
            {
                strB.Append(this.element[i]);
            }

            this.element = strB.ToString();
        }

        public void AddContent(string content)
        {
            int indexOfFirstBiggerThanSign = this.element.IndexOf(">");
            this.element = this.element.Substring(0, indexOfFirstBiggerThanSign + 1) + content + 
                this.element.Substring(indexOfFirstBiggerThanSign + 1);
        }

        public static string operator *(ElementBuilder elemetBuilder, int multyplier)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < multyplier; i++)
            {
                result.Append(elemetBuilder);
            }

            return result.ToString();
        }

        public override string ToString()
        {
            return this.element;
        }
    }
}
