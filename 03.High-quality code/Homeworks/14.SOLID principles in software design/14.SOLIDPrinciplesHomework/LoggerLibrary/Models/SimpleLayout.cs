using System;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary.Models
{
    public class SimpleLayout : ILayout
    {
        public string PrintingFormat(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            return string.Format("{0} - {1} - {2}",
                dateTime,
                reportLevel,
                message);
        }
    }
}
