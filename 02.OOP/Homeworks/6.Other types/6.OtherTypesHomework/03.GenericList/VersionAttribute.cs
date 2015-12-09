using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.GenericList
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
        AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        private string version;

        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version
        {
            get { return this.version; }
            set
            {
                string pattern = @"[0-9]+\.[0-9]+";
                Regex regex = new Regex(pattern);
                if (!regex.Match(value).Success)
                {
                    throw new ArgumentException("The version you've entered is not in the correct format (for example 2.11)", "version");
                }

                this.version = value;
            }
        }
    }
}
