using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Core.Interfaces
{
    /// <summary>
    /// Prints the output data
    /// </summary>
    public interface IRenderer
    {
        /// <summary>
        /// Prints a line
        /// </summary>
        /// <param name="line">the line to be printed</param>
        void Write(string line);

        /// <summary>
        /// Prints a line and goes to the next line
        /// </summary>
        /// <param name="line">the line to be printed</param>
        void WriteLine(string line);
    }
}
