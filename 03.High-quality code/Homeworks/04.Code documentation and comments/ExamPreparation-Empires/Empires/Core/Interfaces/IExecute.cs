using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Core.Interfaces
{
    /// <summary>
    /// Executes commands
    /// </summary>
    public interface IExecute
    {
        /// <summary>
        /// Returns the result according to the given commandArgs parameter
        /// </summary>
        /// <param name="commandArgs">an array of arguments of the command</param>
        /// <returns>a string result from the executed command</returns>
        string ExecuteCommand(string[] commandArgs);
    }
}
