using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Core.Interfaces
{
    /// <summary>
    /// Reads the input data
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Reads a line from a file or something like
        /// </summary>
        /// <returns>a string line</returns>
        string ReadLine();
    }
}
