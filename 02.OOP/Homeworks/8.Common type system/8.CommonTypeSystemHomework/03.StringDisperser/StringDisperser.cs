using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringDisperser
{
    public class StringDisperser : ICloneable, IComparable<StringDisperser>
    {
        public StringDisperser(params string[] strings)
        {
            this.Arguments = strings;
        }

        public IList<string> Arguments { get; set; }

        public override bool Equals(object obj)
        {
            StringDisperser strDisp = obj as StringDisperser;
            if (strDisp == null)
            {
                return false;
            }

            if (this.Arguments.Count != strDisp.Arguments.Count)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < this.Arguments.Count; i++)
                {
                    if (this.Arguments[i] != strDisp.Arguments[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 1;
            foreach (var argument in this.Arguments)
            {
                hashCode = hashCode ^ argument.GetHashCode();
            }

            return hashCode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var argument in this.Arguments)
            {
                result.Append(argument);
            }

            return result.ToString();
        }

        public static bool operator ==(StringDisperser strDisp1, StringDisperser strDisp2)
        {
            return strDisp1.Equals(strDisp2);
        }

        public static bool operator !=(StringDisperser strDisp1, StringDisperser strDisp2)
        {
            return !(strDisp1.Equals(strDisp2));
        }

        public object Clone()
        {
            IList<string> arguments = new List<string>();
            foreach (var argument in this.Arguments)
            {
                arguments.Add(argument);
            }

            var cloning = new StringDisperser(arguments.ToArray());

            return cloning;
        }

        public int CompareTo(StringDisperser other)
        {
            if (string.Compare(this.ToString(), other.ToString(), StringComparison.Ordinal) != 0)
            {
                if (string.Compare(this.ToString(), other.ToString(), StringComparison.Ordinal) < 0)
                {
                    return 1;
                }
                return -1;
            }

            return 0;
        }
    }
}
